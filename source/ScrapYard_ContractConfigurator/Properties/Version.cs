﻿//74
// 
// This code was generated by a tool. Any changes made manually will be lost
// the next time this code is regenerated.
// 

using System.Reflection;

[assembly: AssemblyFileVersion("2.2.99.74")]
[assembly: AssemblyVersion("2.2.99.1")]
[assembly: AssemblyInformationalVersion("2.2.99")]
[assembly: KSPAssembly("ScrapYard", 2,2,99)]

namespace ScrapYard_ContractConfigurator
{
	/// <summary>Version - retrieved at compile from ScrapYard.version</summary>
	public static class Version
	{
		/// <summary>Major revision</summary>
		public const int major = 2;
		/// <summary>Minor revision</summary>
		public const int minor = 2;
		/// <summary>Patch revision</summary>
		public const int patch = 99;
		/// <summary>Build revision</summary>
		public const int build = 1;
		/// <summary>Version String const</summary>
		public const string Number = "2.2.99.1";
#if DEBUG
		/// <summary>Debug Version String const</summary>
        public const string Text = Number + "-zed'K BETA DEBUG";
		/// <summary>Debug SVersion String const</summary>
        public const string SText = Number + "-zed'K BETA DEBUG";
#else
		/// <summary>Text Version String const</summary>
        public const string Text = Number + "-zed'K";
		/// <summary>Plain Text Version String const</summary>
		public const string SText = Number;
#endif
	}
}