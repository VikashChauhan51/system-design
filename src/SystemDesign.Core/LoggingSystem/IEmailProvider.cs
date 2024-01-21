

namespace SystemDesign.Core.LoggingSystem;


public interface IEmailProvider
{
    void Send(List<string> toRecipents, List<string> ccRecipents, string title, string body);
}
