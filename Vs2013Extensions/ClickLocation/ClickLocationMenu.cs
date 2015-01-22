using System.ComponentModel.Design;
using System.Windows.Forms;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;

namespace ErR.Vs2013Extensions.ClickLocation
{
	public class ClickLocationMenu
	{
		private readonly DTE2 _dte2;
		private readonly OleMenuCommandService _mcs;

		public ClickLocationMenu(DTE2 dte2, OleMenuCommandService mcs)
		{
			_dte2 = dte2;
			_mcs = mcs;
		}

		public void Initialize()
		{
			if (null != _mcs)
			{
				var menuCommandID = new CommandID(GuidList.guidVs2013ExtensionsCmdSet, (int) PkgCmdIDList.cmdidErrExtensions);
				var menuItem = new MenuCommand(HandleRightClick, menuCommandID);
				_mcs.AddCommand(menuItem);
			}
		}

		public void HandleRightClick(object sender, System.EventArgs e)
		{
			var activeWindow = _dte2.ActiveWindow;

			var activeFileDetails = new ActiveFileDetails
			{
				FullPath = activeWindow.Document.FullName,
				CurrentLine = ((TextSelection) (activeWindow.Selection)).CurrentLine
			};

			Clipboard.SetText(activeFileDetails.ToString());
		}
	}
}