﻿using KSP.UI.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.Localization;

namespace ScrapYard.UI
{
    public class InstanceSelectorUI : WindowBase
    {
        //private const string Text = "Use New Part";
        private const string Text = "#SYD-GUI-20";
        protected Vector2 scrollPos;


        public InstanceSelectorVM InstanceVM { get; set; }

        public InstanceSelectorUI() : base(3742, "Inventory", true, false)
        {
            SetVisibleScenes(GameScenes.EDITOR);
            SetSize(500, 100, 300, Screen.height - 200);
            SetResizeable(true, true);

            OnMouseOver.Add(() => { InstanceVM.OnMouseOver(); });
            OnMouseExit.Add(() => { InstanceVM.OnMouseExit(); });
        }

        public override void Draw(int windowID)
        {
            if (!HighLogic.LoadedSceneIsEditor)
            {
                Close();
                return;
            }
            if (ApplicationLauncher.Ready)
            {
                EventListeners.Instance.Button.SetTrue(false);
            }
            GUILayout.BeginVertical();

            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label(InstanceVM.SelectedPartName);
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            if (InstanceVM.ApplyPart != null)
            {
                //if (GUILayout.Button(Text))
                if (GUILayout.Button(Localizer.Format("#SYD-GUI-20")))
                {
                    InstanceVM.RefreshApplyPart();
                }
            }
            else
            {
                //if (GUILayout.Button("Select New Part"))
                if (GUILayout.Button(Localizer.Format("#SYD-GUI-21")))
                {
                    //spawn a new part
                    InstanceVM.SpawnNewPart();
                }
            }

            scrollPos = GUILayout.BeginScrollView(scrollPos);

            //Show sets of parts in the inventory, grouped by usage/modules
            if (InstanceVM.Parts?.Any() == true)
            {
                foreach (List<PartInstance> list in InstanceVM.Parts)
                {
                    PartInstance instance = list.FirstOrDefault();

                    if (instance != null)
                    {
                        GUILayout.BeginVertical(GUI.skin.textArea);
                        GUILayout.BeginHorizontal();
                        int recovered = instance.BackingPart.TrackerModule.TimesRecovered;
                        //string use = recovered != 1 ? "Uses" : "Use";
                        string _0 = Localizer.Format("#SYD-GUI-0");
                        string _1 = Localizer.Format("#SYD-GUI-1");
                        //string use = recovered != 1 ? Localizer.Format("#SYD-GUI-0") : Localizer.Format("#SYD-GUI-1");
                        string use = recovered != 1 ? _0 : _1;

                        //GUILayout.Label($"{recovered} Previous {use}");
                        //GUILayout.Label($"{recovered} #SYD-GUI-2 {use}");
                        GUILayout.Label(Localizer.Format("#SYD-GUI-2", recovered, use));

                        GUILayout.FlexibleSpace();
                        //GUILayout.Label($"{list.Count} In Inventory");
                        GUILayout.Label(Localizer.Format("#SYD-GUI-4", list.Count));

                        GUILayout.EndHorizontal();
                        instance.Draw();
                        GUILayout.EndVertical();
                    }
                }
            }

            GUILayout.EndScrollView();

            //GUILayout.Label("Whole-Vessel Quick Options:");
            GUILayout.Label(Localizer.Format("#SYD-GUI-5"));
            //InstanceVM.AutoApplyInventory = GUILayout.Toggle(InstanceVM.AutoApplyInventory, "Automatically Quick Apply");
            InstanceVM.AutoApplyInventory = GUILayout.Toggle(InstanceVM.AutoApplyInventory, Localizer.Format("#SYD-GUI-6"));
            GUILayout.BeginHorizontal();
            //if (GUILayout.Button("Quick Apply"))
            if (GUILayout.Button(Localizer.Format("#SYD-GUI-7")))
            {
                InstanceVM.ApplyInventoryToEditorVessel();
            }
            //if (GUILayout.Button("New Parts"))
            if (GUILayout.Button(Localizer.Format("#SYD-GUI-8")))
            {
                InstanceVM.MakeFresh();
            }
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
            base.Draw(windowID);

            //if clicked and holding a part, disable the on_partDropped event
            if (MouseIsOver)
            {
                if (Mouse.Left.GetButtonDown())
                {
                    InstanceVM.DisablePartDropping();
                }
            }
            else
            {
                InstanceVM.RestorePartDropping();
            }
        }

        public void Show(Part basePart, Part applyTo)
        {
            base.Show();
            InstanceVM = new InstanceSelectorVM(ScrapYard.Instance.TheInventory,
                basePart,
                applyTo,
                ScrapYard.Instance.Settings.CurrentSaveSettings.OverrideFunds);
        }

        public override void Show()
        {
            base.Show();
            InstanceVM = new InstanceSelectorVM();
        }
    }
}
