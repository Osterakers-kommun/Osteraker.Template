namespace Osteraker.Template.CountWords.Tests;

using System.Threading;
using Osteraker.Template.CountWords.Definitions;
using NUnit.Framework;

[TestFixture]
public class UnitTests
{
    [Test]
    public void Good_Input_Two_Normal_Words()
    {
        var input = new Input { Text = "foobar max" };

        var options = new Options { ThrowErrorOnFailure = true, ErrorMessageOnFailure = null };

        var result = Template.CountWords(input, options, CancellationToken.None);

        Assert.That(result.Output, Is.EqualTo(2));
    }

    [Test]
    public void Good_Input_Two_Special_Words()
    {
        var input = new Input { Text = "foobar---, max3232!" };

        var options = new Options { ThrowErrorOnFailure = true, ErrorMessageOnFailure = null };

        var result = Template.CountWords(input, options, CancellationToken.None);

        Assert.That(result.Output, Is.EqualTo(2));
    }
}
