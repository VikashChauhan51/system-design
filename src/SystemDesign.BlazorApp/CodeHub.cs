using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;


namespace SystemDesign.BlazorApp;

public class CodeHub: Hub
{
    // A method to compile and execute C# code on the server side
    public async Task RunCode(string code)
    {
        // Save the current console output
        var oldOut = Console.Out;
        // Create a script options object with the necessary references and imports
        var options = ScriptOptions.Default
            .AddReferences(
                typeof(object).Assembly,
                typeof(Console).Assembly,
                typeof(System.Linq.Enumerable).Assembly)
            .AddImports(
                "System",
                "System.IO",
                "System.Linq");

        // Create a string writer to capture the console output
        using var writer = new StringWriter();

        // Redirect the console output to the string writer
        Console.SetOut(writer);
        Console.SetError(writer);
        

        try
        {
            // Create and run a C# script with the given code and options
            var script = CSharpScript.Create(code, options);
            var result = await script.RunAsync();

            // If the script has a return value, append it to the output
            if (result.ReturnValue != null)
            {
                writer.WriteLine(result.ReturnValue);
            }
            // Restore the original console output
            Console.SetOut(oldOut);

            var output = writer.ToString();
            // Send the output to the client
            await Clients.Caller.SendAsync("ReceiveOutput", output);
        }
        catch (CompilationErrorException ex)
        {
            // If the script has compilation errors, send them to the client
            await Clients.Caller.SendAsync("ReceiveOutput", string.Join(Environment.NewLine, ex.Diagnostics));
        }
        catch (Exception ex)
        {
            // If the script has runtime errors, send them to the client
            await Clients.Caller.SendAsync("ReceiveOutput", ex.Message);
        }
    }
}
