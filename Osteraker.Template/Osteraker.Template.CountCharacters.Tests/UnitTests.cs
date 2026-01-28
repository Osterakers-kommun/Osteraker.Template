namespace Osteraker.Template.CountCharacters.Tests;

using System.Threading;
using Osteraker.Template.CountCharacters.Definitions;
using NUnit.Framework;

[TestFixture]
public class UnitTests
{
    [Test]
    public void Good_Input()
    {
        var input = new Input { Text = "foobar" };

        var options = new Options { ThrowErrorOnFailure = true, ErrorMessageOnFailure = null };

        var result = Template.CountCharacters(input, options, CancellationToken.None);

        Assert.That(result.Output, Is.EqualTo(6));
    }
}
