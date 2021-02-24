using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NHSUK.FrontEndLibrary.TagHelpers.Constants;

namespace NHSUK.FrontEndLibrary.TagHelpers.Tags.Table
{
  [HtmlTargetElement(TagHelperNames.NhsTableHeadTag, ParentTag = TagHelperNames.NhsTableTag)]
  [RestrictChildren(TagHelperNames.NhsTableItemTag)]
  public class NhsTableHeadTagHelper : NhsBaseTagHelper
  {
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      await base.ProcessAsync(context, output);
      output.TagName = HtmlElements.Thead;
      SetClassAttribute(output, CssClasses.NhsUkTableHead);
      SetAttribute(output, "role", "rowgroup");

      output.PreContent.SetHtmlContent("<tr class=\"nhsuk-table__row\" role=\"row\">");
      output.PostContent.SetHtmlContent("</tr>");

      output.TagMode = TagMode.StartTagAndEndTag;

      context.Items["ParentType"] = TagHelperNames.NhsTableHeadTag;
    }
  }
}
