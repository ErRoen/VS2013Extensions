// Guids.cs
// MUST match guids.h
using System;

namespace ErR.Vs2013Extensions
{
	internal static class GuidList
	{
		public const string guidVs2013ExtensionsPkgString = "e5dea253-5280-4153-8e66-d4e42937d83a";
		public const string guidVs2013ExtensionsCmdSetString = "3384d588-6492-455e-9058-d78044f0900a";

		public static readonly Guid guidVs2013ExtensionsCmdSet = new Guid(guidVs2013ExtensionsCmdSetString);
	};
}