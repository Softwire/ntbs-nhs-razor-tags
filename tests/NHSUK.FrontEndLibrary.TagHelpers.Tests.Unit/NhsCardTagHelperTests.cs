using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NHSUK.FrontEndLibrary.TagHelpers.Constants;
using NHSUK.FrontEndLibrary.TagHelpers.Tags.Card;
using Xunit;

namespace NHSUK.FrontEndLibrary.TagHelpers.Tests.Unit
{
  public class NhsCardTagHelperTests
  {
    private readonly TagHelperOutput _tagHelperOutput;
    private readonly TagHelperContext _tagHelperContext;
    private readonly NhsCardTagHelper _tagHelper;
    private const string HeadingText = "Give blood";
    private const string CardDescription = "Please register";
    private const string Href = "https://www.nhs.uk";
    private const string ImageUrl = "https://assets.nhs.uk/prod/images/MS_1018_give_blood.2e16d0ba.fill-2400x1350.jpg";

    public NhsCardTagHelperTests()
    {
      _tagHelper = new NhsCardTagHelper { HeadingText = HeadingText };
      _tagHelperContext = new TagHelperContext(
        new TagHelperAttributeList
        {
            new TagHelperAttribute("href", new HtmlString(Href))
        },
        new Dictionary<object, object>(),
        Guid.NewGuid().ToString("N"));

      _tagHelperOutput = new TagHelperOutput(string.Empty,
         new TagHelperAttributeList(),
         (useCachedResult, encoder) =>
         {
           var tagHelperContent = new DefaultTagHelperContent();
           return Task.FromResult(tagHelperContent.SetHtmlContent(CardDescription));
         });
    }

    [Fact]
    public async void ProcessAsync_Should_Set_TagName()
    {
      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(HtmlElements.Div, _tagHelperOutput.TagName);
    }

    [Fact]
    public async void ProcessAsync_Should_Set_TagMode()
    {
      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(TagMode.StartTagAndEndTag, _tagHelperOutput.TagMode);
    }

    [Theory]
    [InlineData(CardType.Standard)]
    [InlineData((CardType)(-1))]
    public async void ProcessAsync_Should_Set_Standard_ClassAttribute(CardType type)
    {
      _tagHelper.CardType = type;
      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(CssClasses.NhsUkCard, _tagHelperOutput.Attributes[HtmlAttributes.ClassAttribute].Value);
    }

    [Fact]
    public async void ProcessAsync_Should_Set_Clickable_ClassAttribute()
      {
      _tagHelper.CardType = CardType.Clickable;
      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(CssClasses.NhsUkCardClickable, _tagHelperOutput.Attributes[HtmlAttributes.ClassAttribute].Value);
    }

    [Fact]
    public async void ProcessAsync_Should_Set_PreContent_Standard()
    {
        await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);
        Assert.Equal($"<div class=\"nhsuk-card__content\"><h3 class=\"nhsuk-card__heading\">{HeadingText}</h3>" +
                     $"<p class=\"nhsuk-card__description\">",
            _tagHelperOutput.PreContent.GetContent());
    }

    [Fact]
    public async void ProcessAsync_Should_Set_PreContent_Standard_With_Image()
    {
        _tagHelper.ImageUrl = ImageUrl;

        await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);
        Assert.Equal($"<img class=\"nhsuk-card__img\" src=\"{ImageUrl}\" alt=\"\">" +
                     $"<div class=\"nhsuk-card__content\">" +
                     $"<h3 class=\"nhsuk-card__heading\">{HeadingText}</h3>" +
                     $"<p class=\"nhsuk-card__description\">",
            _tagHelperOutput.PreContent.GetContent());
    }

    [Fact]
    public async void ProcessAsync_Should_Set_PreContent_Clickable()
    {
        _tagHelper.CardType = CardType.Clickable;

        await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);
        Assert.Equal($"<div class=\"nhsuk-card__content\">" +
                     $"<h3 class=\"nhsuk-card__heading\">" +
                     $"<a class=\"nhsuk-card__link\" href=\"{Href}\">{HeadingText}</a>" +
                     $"</h3>" +
                     $"<p class=\"nhsuk-card__description\">",
            _tagHelperOutput.PreContent.GetContent());
    }

    [Fact]
    public async void ProcessAsync_Should_Set_PreContent_Clickable_With_Image()
    {
        _tagHelper.ImageUrl = ImageUrl;
        _tagHelper.CardType = CardType.Clickable;

        await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);
        Assert.Equal($"<img class=\"nhsuk-card__img\" src=\"{ImageUrl}\" alt=\"\">" +
                     $"<div class=\"nhsuk-card__content\">" +
                     $"<h3 class=\"nhsuk-card__heading\">" +
                     $"<a class=\"nhsuk-card__link\" href=\"{Href}\">{HeadingText}</a>" +
                     $"</h3>" +
                     $"<p class=\"nhsuk-card__description\">",
            _tagHelperOutput.PreContent.GetContent());
    }

    [Theory]
    [InlineData(CardType.Standard, null)]
    [InlineData(CardType.Standard, ImageUrl)]
    [InlineData(CardType.Clickable, null)]
    [InlineData(CardType.Clickable, ImageUrl)]
    public async void ProcessAsync_Should_Set_PostContent(CardType cardType, string imageUrl)
    {
        _tagHelper.CardType = cardType;
        _tagHelper.ImageUrl = imageUrl;

        await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);
        Assert.Equal("</p></div>", _tagHelperOutput.PostContent.GetContent());
    }

    [Theory]
    [InlineData(CardType.Standard, null)]
    [InlineData(CardType.Standard, ImageUrl)]
    [InlineData(CardType.Clickable, null)]
    [InlineData(CardType.Clickable, ImageUrl)]
    public async void ProcessAsync_Should_Set_Content(CardType cardType, string imageUrl)
    {
        _tagHelper.CardType = cardType;
        _tagHelper.ImageUrl = imageUrl;

        await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);
        Assert.Equal(CardDescription, _tagHelperOutput.Content.GetContent());
    }

    [Theory]
    [InlineData(GridColumnWidth.Full, CssClasses.NhsUkGridFull)]
    [InlineData(GridColumnWidth.OneHalf, CssClasses.NhsUkGridOneHalf)]
    [InlineData(GridColumnWidth.OneQuarter, CssClasses.NhsUkGridOneQuarter)]
    [InlineData(GridColumnWidth.OneThird, CssClasses.NhsUkGridOneThird)]
    [InlineData(GridColumnWidth.TwoThirds, CssClasses.NhsUkGridTwoThirds)]
    [InlineData(GridColumnWidth.ThreeQuarters, CssClasses.NhsUkGridThreeQuarters)]
    [InlineData((GridColumnWidth)(-1), CssClasses.NhsUkGridFull)]
    public async void ProcessAsync_Should_Set_CardGroup_PreElement(GridColumnWidth width, string classAttribute)
    {
      _tagHelperContext.Items["ParentColumnWidth"] = width;

      var expected = $"<li class=\"{classAttribute} nhsuk-card-group__item\">";

      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(expected, _tagHelperOutput.PreElement.GetContent());
    }

    [Fact]
    public async void ProcessAsync_Should_Not_Set_PreElement_If_No_CardGroup()
    {
      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(string.Empty, _tagHelperOutput.PreElement.GetContent());
    }

    [Theory]
    [InlineData(GridColumnWidth.Full)]
    [InlineData(GridColumnWidth.OneHalf)]
    [InlineData(GridColumnWidth.OneQuarter)]
    [InlineData(GridColumnWidth.OneThird)]
    [InlineData(GridColumnWidth.TwoThirds)]
    [InlineData(GridColumnWidth.ThreeQuarters)]
    public async void ProcessAsync_Should_Set_CardGroup_PostElement(GridColumnWidth width)
    {
      _tagHelperContext.Items["ParentColumnWidth"] = width;

      var expected = "</li>";

      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(expected, _tagHelperOutput.PostElement.GetContent());
    }

    [Fact]
    public async void ProcessAsync_Should_Not_Set_PostElement_If_No_CardGroup()
    {
      await _tagHelper.ProcessAsync(_tagHelperContext, _tagHelperOutput);

      Assert.Equal(string.Empty, _tagHelperOutput.PostElement.GetContent());
    }
  }
}
