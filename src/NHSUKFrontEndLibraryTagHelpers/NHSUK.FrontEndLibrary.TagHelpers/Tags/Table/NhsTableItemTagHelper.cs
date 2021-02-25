using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NHSUK.FrontEndLibrary.TagHelpers.Constants;

namespace NHSUK.FrontEndLibrary.TagHelpers.Tags.Table
{
  [HtmlTargetElement(TagHelperNames.NhsTableItemTag)]
  public class NhsTableItemTagHelper : NhsBaseTagHelper
  {
    [HtmlAttributeName(NhsUkTagHelperAttributes.CellIsHeader)]
    public bool CellIsHeader { get; set; }

    [HtmlAttributeName(NhsUkTagHelperAttributes.HeadingText)]
    public string HeadingText { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      await base.ProcessAsync(context, output);
      var content = (await output.GetChildContentAsync()).GetContent();

      if (context.Items.ContainsKey("ParentType"))
      {
        if (context.Items["ParentType"].ToString() == TagHelperNames.NhsTableHeadTag)
        {
          output.TagName = HtmlElements.Th;
          SetClassAttribute(output, CssClasses.NhsUkTableHeader);
          SetAttribute(output, "scope", "col");
          SetAttribute(output, "role", "columnheader");
        }
        else
        {
          output.TagName = CellIsHeader ? HtmlElements.Th : HtmlElements.Td;
          SetClassAttribute(output, CssClasses.NhsUkTableCell);
        }
      }

      if (!string.IsNullOrWhiteSpace(HeadingText))
      {
        output.PreContent.SetHtmlContent($"<span class=\"nhsuk-table-responsive__heading\">{HeadingText}</span>");
      }

      output.Content.SetHtmlContent(content);

      output.TagMode = TagMode.StartTagAndEndTag;
    }
  }
}
