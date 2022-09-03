﻿using ScrapYard.Modules;
using ScrapYard.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ScrapYard
{
    /// <summary>
    /// This is the remote-side of the API, where all calls through the wrapper funnel through.
    /// It can also be referenced directly, and it is recommended that you interact with ScrapYard through these methods exclusively.
    /// This may be required later on, with everything else being made internal (probably not, but it'd be better design)
    /// </summary>
    public sealed class APIManager
    {
        private static APIManager _instance = new APIManager();

        /// <summary>
        /// A static instance of the APIManager
        /// </summary>
        public static APIManager Instance
        {
            get
            {
                return _instance;
            }
        }

        #region Inventory Manipulation
        /// <summary>
        /// Takes a List of Parts and returns the Parts that are present in the inventory. 
        /// </summary>
        /// <param name="sourceParts">Source list of parts</param>
        /// <param name="strictness">The strictness enum value name.</param>
        /// <returns>List of Parts that are in the inventory</returns>
        public IList<Part> GetPartsInInventory_Parts(IEnumerable<Part> sourceParts, string strictness)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return new List<Part>();
            }
            ComparisonStrength actualStrictness = parseStrictnessString(strictness);
            List<Part> inInventory = new List<Part>();
            PartInventory InventoryCopy = ScrapYard.Instance.TheInventory.Copy();
            foreach (Part part in sourceParts)
            {
                InventoryPart inputPart = new InventoryPart(part);
                if (InventoryCopy.RemovePart(inputPart, actualStrictness) != null)
                {
                    inInventory.Add(part);
                }
            }
            return inInventory;
        }

        /// <summary>
        /// Takes a List of part ConfigNodes and returns the ConfigNodes that are present in the inventory. 
        /// Assumes the default strictness.
        /// </summary>
        /// <param name="sourceParts">Source list of parts</param>
        /// <returns>List of part ConfigNodes that are in the inventory</returns>
        public IList<ConfigNode> GetPartsInInventory_ConfigNodes(IEnumerable<ConfigNode> sourceParts, string strictness)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return new List<ConfigNode>();
            }
            ComparisonStrength actualStrictness = parseStrictnessString(strictness);
            List<ConfigNode> inInventory = new List<ConfigNode>();
            PartInventory InventoryCopy = ScrapYard.Instance.TheInventory.Copy();
            foreach (ConfigNode part in sourceParts)
            {
                InventoryPart inputPart = new InventoryPart(part);
                if (InventoryCopy.RemovePart(inputPart, actualStrictness) != null)
                {
                    inInventory.Add(part);
                }
            }
            return inInventory;
        }

        /// <summary>
        /// Adds a list of parts to the Inventory
        /// </summary>
        /// <param name="parts">The list of parts to add</param>
        /// <param name="incrementRecovery">If true, increments the number of recoveries in the tracker</param>
        public void AddPartsToInventory_Parts(IEnumerable<Part> parts, bool incrementRecovery)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return;
            }
            foreach (Part part in parts)
            {
                InventoryPart iPart = new InventoryPart(part);
                if (incrementRecovery)
                {
                    iPart.TrackerModule.TimesRecovered++;
                }
                ScrapYard.Instance.TheInventory.AddPart(iPart);
            }
        }

        /// <summary>
        /// Adds a list of parts to the Inventory
        /// </summary>
        /// <param name="parts">The list of parts to add</param>
        /// <param name="incrementRecovery">If true, increments the number of recoveries in the tracker</param>
        public void AddPartsToInventory_Nodes(IEnumerable<ConfigNode> parts, bool incrementRecovery)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return;
            }
            foreach (ConfigNode part in parts)
            {
                InventoryPart iPart = new InventoryPart(part);
                if (incrementRecovery)
                {
                    iPart.TrackerModule.TimesRecovered++;
                }
                ScrapYard.Instance.TheInventory.AddPart(iPart);
            }
        }

        /// <summary>
        /// Adds a single part to the inventory, increments the recovery tracker if specified
        /// </summary>
        /// <param name="sourcePart">The source part to add</param>
        /// <param name="incrementRecovery">If true, increases the number of recoveries</param>
        /// <returns>True if added, false otherwise</returns>
        public bool AddPartToInventory_Part(Part sourcePart, bool incrementRecovery)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return false;
            }

            InventoryPart iPart = new InventoryPart(sourcePart);
            if (incrementRecovery)
            {
                iPart.TrackerModule.TimesRecovered++;
            }

            return (ScrapYard.Instance.TheInventory.AddPart(iPart) != null);
        }

        /// <summary>
        /// Adds a single part to the inventory, increments the recovery tracker if specified
        /// </summary>
        /// <param name="sourcePart">The source part to add</param>
        /// <param name="incrementRecovery">If true, increases the number of recoveries</param>
        /// <returns>True if added, false otherwise</returns>
        public bool AddPartToInventory_Node(ConfigNode sourcePart, bool incrementRecovery)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return false;
            }

            InventoryPart iPart = new InventoryPart(sourcePart);
            if (incrementRecovery)
            {
                iPart.TrackerModule.TimesRecovered++;
            }

            return (ScrapYard.Instance.TheInventory.AddPart(iPart) != null);
        }

        /// <summary>
        /// Removes a single part from the inventory.
        /// </summary>
        /// <param name="sourcePart">The part to remove.</param>
        /// <param name="strictness">The strictness to use when searching for the appropriate part.</param>
        /// <returns>True if removed, false otherwise.</returns>
        public bool RemovePartFromInventory_Part(Part sourcePart, string strictness)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return false;
            }

            ComparisonStrength actualStrictness = parseStrictnessString(strictness);

            return (ScrapYard.Instance.TheInventory.RemovePart(new InventoryPart(sourcePart), actualStrictness) != null);
        }

        /// <summary>
        /// Removes a single part from the inventory.
        /// </summary>
        /// <param name="sourcePart">The part to remove.</param>
        /// <param name="strictness">The strictness to use when searching for the appropriate part.</param>
        /// <returns>True if removed, false otherwise.</returns>
        public bool RemovePartFromInventory_Node(ConfigNode sourcePart, string strictness)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return false;
            }

            ComparisonStrength actualStrictness = parseStrictnessString(strictness);

            return (ScrapYard.Instance.TheInventory.RemovePart(new InventoryPart(sourcePart), actualStrictness) != null);
        }

        /// <summary>
        /// Sells/Discards the list of parts out of the inventory
        /// </summary>
        /// <param name="parts">The parts to sell</param>
        /// <returns>The total value of the sale</returns>
        public double SellParts_Parts(IEnumerable<Part> parts)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return 0;
            }

            return InventoryManagement.SellParts(parts.Select(p => new InventoryPart(p)));
        }

        /// <summary>
        /// Sells/Discards the list of parts out of the inventory
        /// </summary>
        /// <param name="parts">The parts to sell</param>
        /// <returns>The total value of the sale</returns>
        public double SellParts_Nodes(IEnumerable<ConfigNode> parts)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return 0;
            }

            return InventoryManagement.SellParts(parts.Select(p => new InventoryPart(p)));
        }

        /// <summary>
        /// Finds an InventoryPart for a given part
        /// </summary>
        /// <param name="sourcePart">The part to search for</param>
        /// <param name="strictness">The strictness to use when searching for the part</param>
        /// <returns>The ConfigNode for the InventoryPart, or null if not found</returns>
        public ConfigNode FindInventoryPart_Part(Part sourcePart, string strictness)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return null;
            }

            ComparisonStrength actualStrictness = parseStrictnessString(strictness);

            return ScrapYard.Instance.TheInventory.FindPart(new InventoryPart(sourcePart), actualStrictness)?.State;
        }

        /// <summary>
        /// Finds an InventoryPart for a given part
        /// </summary>
        /// <param name="sourcePart">The part to search for</param>
        /// <param name="strictness">The strictness to use when searching for the part</param>
        /// <returns>The ConfigNode for the InventoryPart, or null if not found</returns>
        public ConfigNode FindInventoryPart_Node(ConfigNode sourcePart, string strictness)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return null;
            }

            ComparisonStrength actualStrictness = parseStrictnessString(strictness);

            return ScrapYard.Instance.TheInventory.FindPart(new InventoryPart(sourcePart), actualStrictness)?.State;
        }

        /// <summary>
        /// Finds an InventoryPart for a given ID
        /// </summary>
        /// <param name="id">The id of the part to search for.</param>
        /// <returns>The ConfigNode for the InventoryPart, or null if not found</returns>
        public ConfigNode FindInventoryPart_ID(string id)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return null;
            }

            
            if (uint.TryParse(id, out uint partID))
            {
                return ScrapYard.Instance.TheInventory.FindPart(partID)?.State;
            }
            return null;
        }

        /// <summary>
        /// Gets all parts in the inventory as a list of ConfigNodes
        /// </summary>
        /// <returns>The list of all inventory parts</returns>
        public IList<ConfigNode> GetAllInventoryParts()
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return null;
            }

            try
            {
                IEnumerable<ConfigNode> nodes = ScrapYard.Instance.TheInventory.GetAllParts()?.Select(p => p.State);
                if (nodes != null)
                {
                    return new List<ConfigNode>(nodes);
                }
            }
            catch (Exception ex)
            {
                Logging.LogException(ex, "GetAllInventoryParts");
            }
            return null;
        }

        /// <summary>
        /// Refreshes a part node to be fresh and not from the inventory
        /// </summary>
        /// <param name="partNode">The part to refresh</param>
        /// <returns>Success</returns>
        public bool RefreshPart_Node(ConfigNode partNode)
        {
            if (!ScrapYard.Instance.TheInventory.InventoryEnabled)
            {
                return false;
            }

            try
            {
                InventoryPart iPart = new InventoryPart(partNode);
                iPart.ID = 0;
                iPart.TrackerModule.Inventoried = false;
                iPart.TrackerModule.TimesRecovered = 0;

                return true;
            }
            catch (Exception ex)
            {
                Logging.LogException(ex, "RefreshPart_Node");
            }
            return false;
        }
        #endregion Inventory Manipulation

        #region Vessel Processing
        /// <summary>
        /// Removes inventory parts, refunds funds, marks it as tracked
        /// </summary>
        /// <param name="parts">The vessel as a List of Parts</param>
        /// <returns>True if processed, false otherwise</returns>
        public bool ProcessVessel_Parts(IEnumerable<Part> parts)
        {
            if (!ScrapYard.Instance.Settings.EnabledForSave)
            {
                return true;
            }
            //try to get the ID out of the list
            uint? ID = parts.FirstOrDefault()?.persistentId;
            if (!ID.HasValue)
            {
                return false; //for now we can't process this vessel. Sorry. Maybe later we'll be able to add the module
            }

            //check that it isn't already processed
            if (ScrapYard.Instance.ProcessedTracker.IsProcessed(ID))
            {
                return false;
            }

            //remove parts
            InventoryManagement.RemovePartsFromInventory(parts);

            //Mark as processed
            ScrapYard.Instance.ProcessedTracker.TrackVessel(ID, true);

            return true;

        }

        /// <summary>
        /// Removes inventory parts, refunds funds, marks it as tracked
        /// </summary>
        /// <param name="parts">The vessel as a List of Parts</param>
        /// <returns>True if processed, false otherwise</returns>
        public bool ProcessVessel_Nodes(IEnumerable<ConfigNode> partNodes)
        {
            if (!ScrapYard.Instance.Settings.EnabledForSave)
            {
                return true;
            }
            //try to get the ID out of the list
            uint ID = 0;
            if (partNodes.FirstOrDefault()?.TryGetValue("persistentId", ref ID) != true)
            {
                return false; //for now we can't process this vessel. Sorry. Maybe later we'll be able to add the module
            }

            //check that it isn't already processed
            if (ScrapYard.Instance.ProcessedTracker.IsProcessed(ID))
            {
                return false;
            }

            //remove parts
            InventoryManagement.RemovePartsFromInventory(partNodes);

            //Mark as processed
            ScrapYard.Instance.ProcessedTracker.TrackVessel(ID, true);

            return true;

        }

        /// <summary>
        /// Records a build in the part tracker
        /// </summary>
        /// <param name="parts">The vessel as a list of Parts.</param>
        public void RecordBuild_Parts(IEnumerable<Part> parts)
        {
            ScrapYard.Instance.PartTracker.AddBuild(parts);
        }

        /// <summary>
        /// Records a build in the part tracker
        /// </summary>
        /// <param name="parts">The vessel as a list of ConfigNodes.</param>
        public void RecordBuild_Nodes(IEnumerable<ConfigNode> parts)
        {
            ScrapYard.Instance.PartTracker.AddBuild(parts);
        }

        /// <summary>
        /// Sets whether a vessel is tracked or not
        /// </summary>
        /// <param name="id">The ID of the vessel</param>
        /// <param name="newStatus">The status to set</param>
        /// <returns>The previous status</returns>
        public bool SetProcessedStatus_ID(string id, bool newStatus)
        {
            if (uint.TryParse(id, out uint vesselID))
            {
                bool previous = ScrapYard.Instance.ProcessedTracker.TrackVessel(vesselID, newStatus);
                if (!newStatus)
                {
                    //fully remove tracking
                    ScrapYard.Instance.ProcessedTracker.Remove(vesselID);
                }
            }
            return false;
        }
        #endregion Vessel Processing

        #region Part Tracker
        /// <summary>
        /// Gets the number of builds for a part
        /// </summary>
        /// <param name="part">The part to check</param>
        /// <param name="type">The type of build counter to check</param>
        /// <returns>Number of builds for the part</returns>
        public int GetBuildCount_Part(Part part, string type)
        {
            return ScrapYard.Instance.PartTracker.GetBuildsForPart(part, parseTrackType(type));
        }

        /// <summary>
        /// Gets the number of builds for a part
        /// </summary>
        /// <param name="partNode">The ConfigNode of the part to check</param>
        /// <param name="type">The type of build counter to check</param>
        /// <returns>Number of builds for the part</returns>
        public int GetBuildCount_Node(ConfigNode partNode, string type)
        {
            return ScrapYard.Instance.PartTracker.GetBuildsForPart(partNode, parseTrackType(type));
        }

        /// <summary>
        /// Gets the number of uses of a part
        /// </summary>
        /// <param name="part">The part to check</param>
        /// <param name="type">The type of use counter to check</param>
        /// <returns>Number of uses of the part</returns>
        public int GetUseCount_Part(Part part, string type)
        {
            return ScrapYard.Instance.PartTracker.GetUsesForPart(part, parseTrackType(type));
        }

        /// <summary>
        /// Gets the number of uses of a part
        /// </summary>
        /// <param name="partNode">The ConfigNode of the part to check</param>
        /// <param name="type">The type of use counter to check</param>
        /// <returns>Number of uses of the part</returns>
        public int GetUseCount_Node(ConfigNode partNode, string type)
        {
            return ScrapYard.Instance.PartTracker.GetUsesForPart(partNode, parseTrackType(type));
        }

        /// <summary>
        /// Gets the unique ID for the current part.
        /// It is recommended to cache this.
        /// </summary>
        /// <param name="part">The part to get the ID of</param>
        /// <returns>The part's ID (a uint) as a string or null if it can't be gotten</returns>
        public string GetPartID_Part(Part part)
        {
            return new InventoryPart(part).ID.ToString();
        }

        /// <summary>
        /// Gets the unique ID for the current part.
        /// It is recommended to cache this.
        /// </summary>
        /// <param name="part">The part to get the ID of</param>
        /// <returns>The part's ID (a uint) as a string or null if it can't be gotten</returns>
        public string GetPartID_Node(ConfigNode part)
        {
            return new InventoryPart(part).ID.ToString();
        }

        /// <summary>
        /// Gets the number of times a part has been recovered. 
        /// It is recommended to cache this.
        /// </summary>
        /// <param name="part">The part to get the TimesRecovered count of.</param>
        /// <returns>The number of times the part has been recovered.</returns>
        public int GetTimesUsed_Part(Part part)
        {
            return new InventoryPart(part).TrackerModule.TimesRecovered;
        }

        /// <summary>
        /// Gets the number of times a part has been recovered.
        /// It is recommended to cache this.
        /// </summary>
        /// <param name="part">The part to get the TimesRecovered count of.</param>
        /// <returns>The number of times the part has been recovered.</returns>
        public int GetTimesUsed_Node(ConfigNode part)
        {
            return new InventoryPart(part).TrackerModule.TimesRecovered;
        }

        /// <summary>
        /// Checks if the part is pulled from the inventory or is new
        /// </summary>
        /// <param name="part">The part to check</param>
        /// <returns>True if from inventory, false if new</returns>
        public bool PartIsFromInventory_Part(Part part)
        {
            InventoryPart iPart = new InventoryPart(part);
            return iPart.TrackerModule.Inventoried;
        }

        /// <summary>
        /// Checks if the part is pulled from the inventory or is new
        /// </summary>
        /// <param name="part">The part to check</param>
        /// <returns>True if from inventory, false if new</returns>
        public bool PartIsFromInventory_Node(ConfigNode part)
        {
            InventoryPart iPart = new InventoryPart(part);
            return iPart.TrackerModule.Inventoried;
        }
        #endregion Part Tracker

        #region Settings
        //Global settings

        /// <summary>
        /// Gets the list of blacklisted parts. This is readonly.
        /// </summary>
        /// <returns>A Read Only list of the blacklisted parts</returns>
        public IEnumerable<string> GetSetting_PartBlacklist()
        {
            return new ReadOnlyCollection<string>(ScrapYard.Instance.Settings.PartBlacklist.ToList());
        }

        /// <summary>
        /// Gets the value of the AutoApplyInventory setting
        /// </summary>
        /// <returns>The value of the setting</returns>
        public bool GetSetting_AutoApplyInventory()
        {
            return ScrapYard.Instance.Settings.AutoApplyInventory;
        }

        /// <summary>
        /// Sets the value of the AutoApplyInventory setting
        /// </summary>
        /// <param name="value">The value to set</param>
        public void SetSetting_AutoApplyInventory(bool value)
        {
            ScrapYard.Instance.Settings.AutoApplyInventory = value;
        }


        //Save specific settings
        /// <summary>
        /// Gets the value of the ModEnabled save-specific setting for the current save
        /// </summary>
        /// <returns>The value of the setting</returns>
        public bool GetSetting_ModEnabled()
        {
            return ScrapYard.Instance.Settings.EnabledForSave;
        }

        /// <summary>
        /// Gets the value of the UseInventory save-specific setting for the current save
        /// </summary>
        /// <returns>The value of the setting</returns>
        public bool GetSetting_UseInventory()
        {
            return ScrapYard.Instance.Settings.CurrentSaveSettings.UseInventory;
        }

        /// <summary>
        /// Gets the value of the UseTracker save-specific setting for the current save
        /// </summary>
        /// <returns>The value of the setting</returns>
        public bool GetSetting_UseTracker()
        {
            return ScrapYard.Instance.Settings.CurrentSaveSettings.UseTracker;
        }

        /// <summary>
        /// Gets the value of the OverrideFunds save-specific setting for the current save
        /// </summary>
        /// <returns>The value of the setting</returns>
        public bool GetSetting_OverrideFunds()
        {
            return ScrapYard.Instance.Settings.CurrentSaveSettings.OverrideFunds;
        }

        /// <summary>
        /// The percentage of funds returned for selling parts when OverrideFunds is active, for this save
        /// </summary>
        /// <returns>The value of the setting</returns>
        public int GetSetting_FundsSalePercent()
        {
            return ScrapYard.Instance.Settings.CurrentSaveSettings.FundsSalePercent;
        }

        #endregion Settings

        private ComparisonStrength parseStrictnessString(string strictness)
        {
            try
            {
                ComparisonStrength actualStrictness = (ComparisonStrength)Enum.Parse(typeof(ComparisonStrength), strictness);
                return actualStrictness;
            }
            catch
            {
                return ComparisonStrength.MODULES;
            }
        }

        private PartTracker.TrackType parseTrackType(string type)
        {
            try
            {
                PartTracker.TrackType actualStrictness = (PartTracker.TrackType)Enum.Parse(typeof(PartTracker.TrackType), type);
                return actualStrictness;
            }
            catch
            {
                return PartTracker.TrackType.TOTAL;
            }
        }
    }
}
