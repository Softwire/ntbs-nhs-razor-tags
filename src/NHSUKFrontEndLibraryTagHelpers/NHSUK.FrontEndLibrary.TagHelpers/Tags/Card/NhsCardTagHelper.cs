using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NHSUK.FrontEndLibrary.TagHelpers.Constants;

namespace NHSUK.FrontEndLibrary.TagHelpers.Tags.Card
{
  [HtmlTargetElement(TagHelperNames.NhsCardTag, Attributes = NhsUkTagHelperAttributes.HeadingText)]
  public class NhsCardTagHelper : NhsBaseTagHelper
  {
    private string _heading;
    private string _href;
    private string _imageElement;
    private TagHelperContext _context;
    private TagHelperOutput _output;

    [HtmlAttributeName(NhsUkTagHelperAttributes.HeadingText)]
    public string HeadingText { get; set; }

    [HtmlAttributeName(NhsUkTagHelperAttributes.ImageUrl)]
    public string ImageUrl { get; set; }

    [HtmlAttributeName(NhsUkTagHelperAttributes.CardType)]
    public CardType CardType { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      await base.ProcessAsync(context, output);
      _output = output;
      _context = context;
      _output.TagName = HtmlElements.Div;
      _output.Attributes.RemoveAll(HtmlAttributes.HRef);
      if (_context.AllAttributes.ContainsName(HtmlAttributes.HRef))
      {
          _href = _context.AllAttributes[HtmlAttributes.HRef].Value.ToString();
      }

      switch (CardType)
      {
        case CardType.Clickable:
          ClassesToPrepend.Add(CssClasses.NhsUkCardClickable);
          _heading = $"<a class=\"nhsuk-card__link\" href=\"{_href}\">{HeadingText}</a>";
          break;
        default:
          _heading = HeadingText;
          ClassesToPrepend.Add(CssClasses.NhsUkCard);
          break;
      }
      _heading = $"<h3 class=\"nhsuk-card__heading\">{_heading}</h3>";

      UpdateClasses(output);

      if (!string.IsNullOrWhiteSpace(ImageUrl))
      {
          _imageElement = $"<img class=\"nhsuk-card__img\" src=\"{ImageUrl}\" alt=\"\">";
      }

      _output.PreContent.SetHtmlContent($"{_imageElement}<div class=\"nhsuk-card__content\">{_heading}" +
                                        $"<p class=\"nhsuk-card__description\">");
      _output.PostContent.SetHtmlContent("</p></div>");

      if (_context.Items.ContainsKey("ParentColumnWidth"))
      {
        SetPrePostElementHtmlContent();
      }

      var htmlContent = (await output.GetChildContentAsync()).GetContent();
      output.Content.SetHtmlContent(htmlContent);
    }

    private void SetPrePostElementHtmlContent()
    {
      var parentColumnWidth = (GridColumnWidth)_context.Items["ParentColumnWidth"];
      string width;
      switch (parentColumnWidth)
      {
        case GridColumnWidth.OneThird:
          width = CssClasses.NhsUkGridOneThird;
          break;
        case GridColumnWidth.OneQuarter:
          width = CssClasses.NhsUkGridOneQuarter;
          break;
        case GridColumnWidth.OneHalf:
          width = CssClasses.NhsUkGridOneHalf;
          break;
        case GridColumnWidth.TwoThirds:
          width = CssClasses.NhsUkGridTwoThirds;
          break;
        case GridColumnWidth.ThreeQuarters:
          width = CssClasses.NhsUkGridThreeQuarters;
          break;
        case GridColumnWidth.Full:
          width = CssClasses.NhsUkGridFull;
          break;
        default:
          width = CssClasses.NhsUkGridFull;
          break;
      }

      _output.PreElement.SetHtmlContent($"<li class=\"{width} nhsuk-card-group__item\">");
      _output.PostElement.SetHtmlContent("</li>");
    }
  }
}
