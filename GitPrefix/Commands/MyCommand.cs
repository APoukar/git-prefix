using Microsoft.Internal.VisualStudio.PlatformUI;
using Microsoft.VisualStudio;

namespace GitPrefix
{
    [Command(PackageIds.AppendGitPrefix)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("GitPrefix", "Button clicked");
        }
    }
}
