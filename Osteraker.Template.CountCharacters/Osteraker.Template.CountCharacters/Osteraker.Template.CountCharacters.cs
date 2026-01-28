namespace Osteraker.Template.CountCharacters;

using System;
using System.ComponentModel;
using System.Threading;
using Osteraker.Template.CountCharacters.Definitions;
using Osteraker.Template.CountCharacters.Helpers;

/// <summary>
/// Task Class for Template operations.
/// </summary>
public static class Template
{
    /// <summary>
    /// Counts the number of characters in the input string.
    /// [Documentation](https://www.osteraker.se/)
    /// </summary>
    /// <param name="input">Essential parameters.</param>
    /// <param name="options">Additional parameters.</param>
    /// <param name="cancellationToken">A cancellation token provided by Frends Platform.</param>
    /// <returns>object { bool Success, string Output, object Error { string Message, Exception AdditionalInfo } }</returns>
    public static Result CountCharacters(
        [PropertyTab] Input input,
        [PropertyTab] Options options,
        CancellationToken cancellationToken)
    {
        try
        {
            // Cancellation token should be provided to methods that support it
            // and checked during long-running operations, e.g., loops
            cancellationToken.ThrowIfCancellationRequested();

            if (string.IsNullOrEmpty(input?.Text))
                throw new ArgumentNullException(nameof(input), "Input cannot be null.");

            var output = (input.Text ?? string.Empty).Length;

            return new Result
            {
                Success = true,
                Output = output,
                Error = null,
            };
        }
        catch (Exception ex)
        {
            return ErrorHandler.Handle(ex, options.ThrowErrorOnFailure, options.ErrorMessageOnFailure);
        }
    }
}
