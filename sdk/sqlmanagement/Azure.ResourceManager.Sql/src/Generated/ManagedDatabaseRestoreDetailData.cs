// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedDatabaseRestoreDetail data model.
    /// A managed database restore details.
    /// </summary>
    public partial class ManagedDatabaseRestoreDetailData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseRestoreDetailData"/>. </summary>
        public ManagedDatabaseRestoreDetailData()
        {
            FullBackupSets = new ChangeTrackingList<ManagedDatabaseRestoreDetailBackupSetProperties>();
            DiffBackupSets = new ChangeTrackingList<ManagedDatabaseRestoreDetailBackupSetProperties>();
            LogBackupSets = new ChangeTrackingList<ManagedDatabaseRestoreDetailBackupSetProperties>();
            UnrestorableFileList = new ChangeTrackingList<ManagedDatabaseRestoreDetailUnrestorableFileProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseRestoreDetailData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="restoreType"> Restore type. </param>
        /// <param name="status"> Restore status. </param>
        /// <param name="blockReason"> The reason why restore is in Blocked state. </param>
        /// <param name="lastUploadedFileName"> Last uploaded file name. </param>
        /// <param name="lastUploadedFileOn"> Last uploaded file time. </param>
        /// <param name="lastRestoredFileName"> Last restored file name. </param>
        /// <param name="lastRestoredFileOn"> Last restored file time. </param>
        /// <param name="completedPercent"> Percent completed. </param>
        /// <param name="currentRestoredSizeInMB"> Current restored size MB. </param>
        /// <param name="currentRestorePlanSizeInMB"> Current restore plan size MB. </param>
        /// <param name="currentBackupType"> Current backup type. </param>
        /// <param name="currentRestoringFileName"> Current restoring file name. </param>
        /// <param name="numberOfFilesFound"> Number of files detected. </param>
        /// <param name="numberOfFilesQueued"> Number of files queued. </param>
        /// <param name="numberOfFilesSkipped"> Number of files skipped. </param>
        /// <param name="numberOfFilesRestoring"> Number of files restoring. </param>
        /// <param name="numberOfFilesRestored"> Number of files restored. </param>
        /// <param name="numberOfFilesUnrestorable"> Number of files unrestorable. </param>
        /// <param name="fullBackupSets"> Full backup sets. </param>
        /// <param name="diffBackupSets"> Diff backup sets. </param>
        /// <param name="logBackupSets"> Log backup sets. </param>
        /// <param name="unrestorableFileList"> Unrestorable files. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedDatabaseRestoreDetailData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string restoreType, string status, string blockReason, string lastUploadedFileName, DateTimeOffset? lastUploadedFileOn, string lastRestoredFileName, DateTimeOffset? lastRestoredFileOn, int? completedPercent, int? currentRestoredSizeInMB, int? currentRestorePlanSizeInMB, string currentBackupType, string currentRestoringFileName, int? numberOfFilesFound, int? numberOfFilesQueued, int? numberOfFilesSkipped, int? numberOfFilesRestoring, int? numberOfFilesRestored, int? numberOfFilesUnrestorable, IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties> fullBackupSets, IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties> diffBackupSets, IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties> logBackupSets, IReadOnlyList<ManagedDatabaseRestoreDetailUnrestorableFileProperties> unrestorableFileList, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            RestoreType = restoreType;
            Status = status;
            BlockReason = blockReason;
            LastUploadedFileName = lastUploadedFileName;
            LastUploadedFileOn = lastUploadedFileOn;
            LastRestoredFileName = lastRestoredFileName;
            LastRestoredFileOn = lastRestoredFileOn;
            CompletedPercent = completedPercent;
            CurrentRestoredSizeInMB = currentRestoredSizeInMB;
            CurrentRestorePlanSizeInMB = currentRestorePlanSizeInMB;
            CurrentBackupType = currentBackupType;
            CurrentRestoringFileName = currentRestoringFileName;
            NumberOfFilesFound = numberOfFilesFound;
            NumberOfFilesQueued = numberOfFilesQueued;
            NumberOfFilesSkipped = numberOfFilesSkipped;
            NumberOfFilesRestoring = numberOfFilesRestoring;
            NumberOfFilesRestored = numberOfFilesRestored;
            NumberOfFilesUnrestorable = numberOfFilesUnrestorable;
            FullBackupSets = fullBackupSets;
            DiffBackupSets = diffBackupSets;
            LogBackupSets = logBackupSets;
            UnrestorableFileList = unrestorableFileList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Restore type. </summary>
        public string RestoreType { get; }
        /// <summary> Restore status. </summary>
        public string Status { get; }
        /// <summary> The reason why restore is in Blocked state. </summary>
        public string BlockReason { get; }
        /// <summary> Last uploaded file name. </summary>
        public string LastUploadedFileName { get; }
        /// <summary> Last uploaded file time. </summary>
        public DateTimeOffset? LastUploadedFileOn { get; }
        /// <summary> Last restored file name. </summary>
        public string LastRestoredFileName { get; }
        /// <summary> Last restored file time. </summary>
        public DateTimeOffset? LastRestoredFileOn { get; }
        /// <summary> Percent completed. </summary>
        public int? CompletedPercent { get; }
        /// <summary> Current restored size MB. </summary>
        public int? CurrentRestoredSizeInMB { get; }
        /// <summary> Current restore plan size MB. </summary>
        public int? CurrentRestorePlanSizeInMB { get; }
        /// <summary> Current backup type. </summary>
        public string CurrentBackupType { get; }
        /// <summary> Current restoring file name. </summary>
        public string CurrentRestoringFileName { get; }
        /// <summary> Number of files detected. </summary>
        public int? NumberOfFilesFound { get; }
        /// <summary> Number of files queued. </summary>
        public int? NumberOfFilesQueued { get; }
        /// <summary> Number of files skipped. </summary>
        public int? NumberOfFilesSkipped { get; }
        /// <summary> Number of files restoring. </summary>
        public int? NumberOfFilesRestoring { get; }
        /// <summary> Number of files restored. </summary>
        public int? NumberOfFilesRestored { get; }
        /// <summary> Number of files unrestorable. </summary>
        public int? NumberOfFilesUnrestorable { get; }
        /// <summary> Full backup sets. </summary>
        public IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties> FullBackupSets { get; }
        /// <summary> Diff backup sets. </summary>
        public IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties> DiffBackupSets { get; }
        /// <summary> Log backup sets. </summary>
        public IReadOnlyList<ManagedDatabaseRestoreDetailBackupSetProperties> LogBackupSets { get; }
        /// <summary> Unrestorable files. </summary>
        public IReadOnlyList<ManagedDatabaseRestoreDetailUnrestorableFileProperties> UnrestorableFileList { get; }
    }
}
