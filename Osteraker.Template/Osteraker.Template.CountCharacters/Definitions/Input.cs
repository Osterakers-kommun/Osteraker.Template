namespace Osteraker.Template.CountCharacters.Definitions;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Essential parameters.
/// </summary>
public class Input
{
    /// <summary>
    /// The input string/text to be counted.
    /// </summary>
    /// <example>foobar</example>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue("Text input")]
    public string Text { get; set; }
}
