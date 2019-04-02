﻿/*
	Copyright (c) 2017 Denis Zykov

	This is part of "Charon: Game Data Editor" Unity Plugin.

	Charon Game Data Editor Unity Plugin is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see http://www.gnu.org/licenses.
*/

using System;
using System.Diagnostics.CodeAnalysis;
using GameDevWare.Charon.Async;
using GameDevWare.Charon.Utils;
using UnityEditor;
using UnityEngine;

namespace GameDevWare.Charon.Windows
{
	internal class AboutWindow : EditorWindow
	{
		private string editorVersion = Resources.UI_UNITYPLUGIN_WINDOW_CHECKING_VERSION;
		private string assetVersion = (Settings.GetCurrentAssetVersion() ?? new Version()).ToString();

		[NonSerialized]
		private Promise<Version> checkToolsVersion;
		private Promise<RequirementsCheckResult> checkRequirements;

		public AboutWindow()
		{
			this.titleContent = new GUIContent(Resources.UI_UNITYPLUGIN_ABOUT_CHARON_TITLE);
			this.maxSize = this.minSize = new Vector2(380, 290);
			this.position = new Rect(
				(Screen.width - this.maxSize.x) / 2,
				(Screen.height - this.maxSize.y) / 2,
				this.maxSize.x,
				this.maxSize.y
			);
		}

		[SuppressMessage("ReSharper", "InconsistentNaming")]
		protected void OnGUI()
		{
			GUILayout.Box("Charon", new GUIStyle { fontSize = 72, alignment = TextAnchor.MiddleCenter });
			GUILayout.Space(10);
			GUILayout.Label(Resources.UI_UNITYPLUGIN_WINDOW_INFO_GROUP, EditorStyles.boldLabel);
			EditorGUILayout.LabelField(Resources.UI_UNITYPLUGIN_ABOUT_EDITOR_VERSION_LABEL, this.editorVersion);
			EditorGUILayout.LabelField(Resources.UI_UNITYPLUGIN_WINDOW_ASSET_VERSION_LABEL, this.assetVersion);
			EditorGUILayout.LabelField(Resources.UI_UNITYPLUGIN_WINDOW_EXTENSIONS_LABEL, string.Join(", ", Settings.SupportedExtensions));
			GUI.enabled = true;
			GUILayout.Space(10);
			GUILayout.Label(Resources.UI_UNITYPLUGIN_WINDOW_SETTINGS_GROUP, EditorStyles.boldLabel);
			Settings.Current.EditorPort = EditorGUILayout.IntField(Resources.UI_UNITYPLUGIN_ABOUT_EDITOR_PORT, Settings.Current.EditorPort);
			Settings.Current.Browser = Convert.ToInt32(EditorGUILayout.EnumPopup(Resources.UI_UNITYPLUGIN_WINDOW_BROWSER, (BrowserType)Settings.Current.Browser));
			if (Settings.Current.Browser == (int)BrowserType.Custom)
			{
				EditorGUILayout.BeginHorizontal();
				{
					Settings.Current.BrowserPath = EditorGUILayout.TextField(Resources.UI_UNITYPLUGIN_WINDOW_BROWSER_PATH, Settings.Current.BrowserPath);
					if (GUILayout.Button(Resources.UI_UNITYPLUGIN_WINDOW_BROWSE_BUTTON, EditorStyles.toolbarButton, GUILayout.Width(70), GUILayout.Height(18)))
					{
						Settings.Current.BrowserPath = EditorUtility.OpenFilePanel(Resources.UI_UNITYPLUGIN_WINDOW_BROWSER_PATH_TITLE, "", "");
						GUI.changed = true;
						this.Repaint();
					}
					GUILayout.Space(5);
				}
				EditorGUILayout.EndHorizontal();
			}
			else
				GUILayout.Space(18);

			GUILayout.Space(18);
			GUILayout.BeginHorizontal();
			EditorGUILayout.Space();
			if (GUILayout.Button(Resources.UI_UNITYPLUGIN_ABOUT_CLOSE_BUTTON, GUILayout.Width(80)))
				this.Close();
			GUILayout.EndHorizontal();

			if (GUI.changed)
				Settings.Current.Save();
		}

		protected void Update()
		{
			if (this.checkRequirements == null)
				this.checkRequirements = CharonCli.CheckRequirementsAsync();
			if (this.checkRequirements.IsCompleted == false)
				return;

			if (this.checkRequirements.HasErrors)
			{
				this.editorVersion = this.checkRequirements.Error.Unwrap().Message;
				return;
			}

			var result = this.checkRequirements.GetResult();
			switch (result)
			{
				case RequirementsCheckResult.MissingRuntime:
					this.editorVersion = Resources.UI_UNITYPLUGIN_WINDOW_CHECK_RESULT_MISSING_MONO_OR_DOTNET;
					break;
				case RequirementsCheckResult.MissingExecutable:
					this.editorVersion = Resources.UI_UNITYPLUGIN_WINDOWCHECK_RESULT_MISSING_TOOLS;
					break;
				case RequirementsCheckResult.Ok:
					if (this.checkToolsVersion == null)
					{
						this.editorVersion = Resources.UI_UNITYPLUGIN_WINDOW_CHECKING_VERSION;
						this.checkToolsVersion = CharonCli.GetVersionAsync();
						this.checkToolsVersion.ContinueWith(r =>
						{
							if (r.HasErrors)
								this.editorVersion = r.Error.Unwrap().Message;
							else
								this.editorVersion = r.GetResult().ToString();
							this.Repaint();
						});
						this.Repaint();
					}
					break;

			}
		}
	}
}
