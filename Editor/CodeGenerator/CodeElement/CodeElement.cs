// Created by Kay
// Copyright 2013 by SCIO System-Consulting GmbH & Co. KG. All rights reserved.
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;

namespace Scio.CodeGeneration
{
	/// <summary>
	/// Marker interface for all code elements.
	/// </summary>
	public interface CodeElement
	{
	}

	public abstract class GenericCodeElement : CodeElement
	{
		protected string content = "";

		protected GenericCodeElement (string str) {
			this.content = str;
		}
		protected GenericCodeElement () {}

		public override string ToString () {
			return string.Format ("{0}", content);
		}
	}
	
}
