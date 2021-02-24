using Microsoft.AspNetCore.Razor.TagHelpers;
using NHSUK.FrontEndLibrary.TagHelpers.Constants;

namespace NHSUK.FrontEndLibrary.TagHelpers.Tags.Card
{
  [HtmlTargetElement(TagHelperNames.NhsCardGroupTag, Attributes = NhsUkTagHelperAttributes.GridColumnWidth)]
  [RestrictChildren(TagHelperNames.NhsCardTag)]
  public class NhsCardGroupTagHelper : NhsBaseTagHelper
  {
    [HtmlAttributeName(NhsUkTagHelperAttributes.GridColumnWidth)]
    public GridColumnWidth GridColumnWidth { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      base.Process(context, output);
      output.TagName = HtmlElements.Ul;
      SetClassAttribute(output, CssClasses.NhsUkCardGroup);

      output.TagMode = TagMode.StartTagAndEndTag;

      context.Items["ParentColumnWidth"] = GridColumnWidth;
    }

  }
}
