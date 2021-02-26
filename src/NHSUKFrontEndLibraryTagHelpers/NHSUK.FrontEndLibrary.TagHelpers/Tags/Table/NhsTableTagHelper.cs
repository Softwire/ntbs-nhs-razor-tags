using Microsoft.AspNetCore.Razor.TagHelpers;
using NHSUK.FrontEndLibrary.TagHelpers.Constants;

namespace NHSUK.FrontEndLibrary.TagHelpers.Tags.Table
{
  [HtmlTargetElement(TagHelperNames.NhsTableTag)]
  [RestrictChildren(TagHelperNames.NhsTableHeadTag, TagHelperNames.NhsTableBodyTag)]
  public class NhsTableTagHelper : NhsBaseTagHelper
  {
    [HtmlAttributeName(NhsUkTagHelperAttributes.Caption)]
    public string Caption { get; set; }

    [HtmlAttributeName(NhsUkTagHelperAttributes.TitleText)]
    public string TitleText { get; set; }

    [HtmlAttributeName(NhsUkTagHelperAttributes.IsWithPanel)]
    public bool IsWithPanel { get; set; }

    [HtmlAttributeName(NhsUkTagHelperAttributes.Responsive)]
    public bool Responsive { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      base.Process(context, output);
      output.TagName = HtmlElements.Table;

      ClassesToPrepend.Add(Responsive ? CssClasses.NhsUkTableResponsive : CssClasses.NhsUkTable);

      UpdateClasses(output);

      if (!string.IsNullOrWhiteSpace(Caption))
      {
        output.PreContent.SetHtmlContent($"<caption class=\"nhsuk-table__caption\">{Caption}</caption>");
      }

      if (IsWithPanel)
      {
        output.PreElement.AppendHtml("<div class=\"nhsuk-table__panel-with-heading-tab\">" +
                                     $"<h3 class=\"nhsuk-table__heading-tab\">{TitleText}</h3>");
        output.PostElement.AppendHtml("</div>");
      }
    }
  }
}
