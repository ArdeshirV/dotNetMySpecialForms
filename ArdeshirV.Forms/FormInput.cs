﻿#region Header

// Form Input
// FormInput.cs : Gets user input values in string variable.
// Copyright© 2019 ArdeshirV@protonmail.com, Licensed under GPLv3+

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion
//-----------------------------------------------------------------------------
namespace ArdeshirV.Forms
{
	/// <summary>
	/// Description of FormInput.
	/// </summary>
	public partial class FormInput : FormBase
	{
		public FormInput()
		{
			InitializeComponent();
		}
		//---------------------------------------------------------------------
		public static new FormInput Show() 
		{
			FormInput form = new FormInput();
            form.ShowDialog();
			return form;
		}
	}
}