namespace Osteraker.Template.Example.Tests;

using System.Threading;
using Osteraker.Template.Example.Definitions;
using NUnit.Framework;

[TestFixture]
public class UnitTests
{
    [Test]
    public void Good_Input_For_Example()
    {
        var input = new Input { Text = "foobar" };

        var options = new Options { ThrowErrorOnFailure = true, ErrorMessageOnFailure = null };

        var result = Template.Example(input, options, CancellationToken.None);

        Assert.That(result.Output, Is.EqualTo(6));
    }
}
