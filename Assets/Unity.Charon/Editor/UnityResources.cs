﻿/*
	Copyright (c) 2015 Denis Zykov

	This is part of Charon Game Data Editor Unity Plugin.

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
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable once CheckNamespace
// ReSharper disable once EmptyNamespace
namespace Assets.Unity.Charon.Editor {

#if UNITY_5 || UNITY_4
    public class Resources
	{
        public const string EXCEPTION_DATASOURCE_CANTCOMPLETETRANSATION = "Can't complete transaction because another is currenly running. This is fatal error which lead to data corruption.";
        public const string EXCEPTION_DATASOURCE_CANTREMOVEREFERENCEDENTITY = "Can't remove entity which is referenced by other entities ({0}).";
        public const string EXCEPTION_DATASOURCE_DATAFORMATERROR = "A data formatting error occurred while reading file.";
        public const string EXCEPTION_DATASOURCE_IOREADERROR = "An IO error occurred while reading file.";
        public const string EXCEPTION_DATASOURCE_MALFORMEDDOCUMENT = "Unknown or malformed document. Failed to read 'ToolsVersion' attribute.";
        public const string EXCEPTION_DATASOURCE_MIGRATIONFAILEDWITHERROR = "Migration to version '{0}' is failed on action '{1}' with error: {2}";
        public const string EXCEPTION_DATASOURCE_MIGRATIONREQUIRED = "Migration to new tools version is required. Use Migrate().";
        public const string EXCEPTION_DATASOURCE_SECURITYERROR = "A security error occurred while reading file.";
        public const string EXCEPTION_DATASOURCE_SYSTEMENTITIESIMPORTFORBIDDEN = "Import of system entities ({0}) is forbidden. Use Restore() instead.";
        public const string EXCEPTION_DATASOURCE_UNKNOWNCHANGETYPE = "Unknown change type '{0}'.";
        public const string EXCEPTION_DATASOURCE_UNKNOWNDATATYPE = "Unknown data type '{0}'.";
        public const string EXCEPTION_DATASOURCE_UNKNOWNIDGENERATOR = "Unknown IdGenerator type '{0}' specified for entity '{1}'.";
        public const string EXCEPTION_DATASOURCE_UNSUPPORTEDSCHEME = "Unsupported scheme '{0}' specified in data source's location.";
        public const string EXCEPTION_DEPENCYRESOLVER_UNABLETORESOLVE = "Unable to resolve service of type '{0}'.";
        public const string EXCEPTION_FILTER_FAILEDTOPARSEEXPR = "Failed to parse filter expression:";
        public const string EXCEPTION_FILTER_UNKNOWNOP = "Unknown operator '{0}'.";
        public const string EXCEPTION_IMPORT_SINGLEENTITYONLISTIMPORT = "Single entity should be specified while importing array of objects.";
        public const string EXCEPTION_INDEX_ATTRIBUTEISNOTINDEXED = "Attribute '{0}' is not indexed and can't be used in Find().";
        public const string EXCEPTION_INDEX_CANTCONVERTID = "Can't convert id '{0}' of type '{1}' to '{2}'.";
        public const string EXCEPTION_INDEX_CANTGETMAXONUNINDEXEDATTR = "Can't get maximum value for attribute '{0}' because it is not indexed.";
        public const string EXCEPTION_INDEX_COMPOSITEIDONEKEYVALUEPAIR = "Composite id should has only one key/value pair.";
        public const string EXCEPTION_INDEX_INDEXBUILDINGERROR = "An error occured while building index '{0}' for entity '{1}'. More detailed information in inner exception.";
        public const string EXCEPTION_METADATA_EXPRESSIONSHOULDBEOFTYPE = "Expression '{0}' should be valid '{1}' expression.";
        public const string EXCEPTION_METADATA_TYPEISNOTSUPPORTED = "Data type '{0}' is not supported.";
        public const string EXCEPTION_METADATA_UNABLETOFINDATTRONENTITY = "Unable to find attribute with id or name '{0}' on entity '{1}'.";
        public const string EXCEPTION_METADATA_UNABLETOFINDENTITY = "Unable to find entity with id or name '{0}'.";
        public const string EXCEPTION_METADATA_UNABLETOFINDLANGUAGE = "Unable to find language with id or name '{0}'.";
        public const string EXCEPTION_SPECIFICATION_CANTFINDFLAGWITHLABEL = "Cant' find flag with label '{0}'.";
        public const string EXCEPTION_VALIDATION_CANTCONVERTDEFAULTVALUETOTYPE = "Can't convert default value '{0}' to type '{1}'.";
        public const string EXCEPTION_VALIDATION_DATATYPECHANGEFORBIDDEN = "Data type change is forbidden for this attribute.";
        public const string EXCEPTION_VALIDATION_DUPLICATEIDINCONTAINER = "Duplicate id '{0}' in container.";
        public const string EXCEPTION_VALIDATION_DUPLICATEUNIQUEATTR = "Duplication of unique value '{0}' of attribute '{1}'.";
        public const string EXCEPTION_VALIDATION_IMPOSSIBLERECURSIVESTRUCTURE = "Adding attribute will create impossible structure recusion. Remove requirement from attribute.";
        public const string EXCEPTION_VALIDATION_ENTITYISSYSTEM = "Entity {0} is system and can't be changed.";
        public const string EXCEPTION_VALIDATION_ENTITYWASCHANGED = "Entity {0} with id '{1}' is changed by someone else.";
        public const string EXCEPTION_VALIDATION_GENERICEXCEPTION = "Validation is failed with following errors:";
        public const string EXCEPTION_VALIDATION_INVALIDVALUEFORMAT = "Value is not valid {0}.";
        public const string EXCEPTION_VALIDATION_MISSINGLOCALIZATIONINLANGUAGE = "Missing localization of value for {0} language.";
        public const string EXCEPTION_VALIDATION_MISSINGREFERENCETYPE = "Referenced entity should be specified for {0} data type.";
        public const string EXCEPTION_VALIDATION_MISSINGREQCOMPONENT = "Missing required component of value: {0}.";
        public const string EXCEPTION_VALIDATION_NAMEISRESERVERFORINTERNALUSE = "This name is reserved for internal use.";
        public const string EXCEPTION_VALIDATION_UNABLETOFINDENTRY = "Unable to find '{1}' with id '{0}'.";
        public const string EXCEPTION_VALIDATION_UNEXPECTEDVALUETYPE = "Unexpected '{0}' value where {1} is expected.";
        public const string EXCEPTION_VALIDATION_VALUEISREQUIRED = "Value is required.";
        public const string EXCEPTION_XLSX_FAILEDTORESOLVEREF = "Failed to resolve '{0}' with id '{1}'.";
        public const string EXCEPTION_XLSX_UNEXPECTEDVALUETYPE = "Unexpected type of value '{0}'.";
        public const string UI_DASHBOARD_ACTIONSBUTTONGROUP = "Actions";
        public const string UI_DASHBOARD_BACKUPPSTARTED = "Backup started.";
        public const string UI_DASHBOARD_BUTTON_BACKUP = "Backup";
        public const string UI_DASHBOARD_BUTTON_EXPORT = "Export";
        public const string UI_DASHBOARD_BUTTON_IMPORT = "Import";
        public const string UI_DASHBOARD_BUTTON_RESTORE = "Restore";
        public const string UI_DASHBOARD_BUTTON_VALIDATE = "Validate";
        public const string UI_DASHBOARD_FAILEDTOSTARTBACKUP = "Failed to start backup.";
        public const string UI_DASHBOARD_FAILEDTOSTARTVALIDATION = "Failed to start validation.";
        public const string UI_DASHBOARD_ISSUESSTATSTITLE = "Issues Statistics";
        public const string UI_DASHBOARD_ISSUESTITLE = "Issues";
        public const string UI_DASHBOARD_MAINTENANCEBUTTONGROUP = "Maintenance";
        public const string UI_DASHBOARD_NOISSUESFOUND = "No issues found.";
        public const string UI_DASHBOARD_NOPROCESSEFOUND = "No processes running.";
        public const string UI_DASHBOARD_PROCESSESTITLE = "Processes";
        public const string UI_DASHBOARD_TITLE = "Home";
        public const string UI_DASHBOARD_VALIDATIONSTARTED = "Validation started.";
        public const string UI_DATASOURCE_PROGRESS_CLONING = "Cloning";
        public const string UI_DATASOURCE_PROGRESS_DONE = "Done";
        public const string UI_DATASOURCE_PROGRESS_ENTRIESEXPORTED = "{0} entries exported";
        public const string UI_DATASOURCE_PROGRESS_ENTRIESIMPORTED = "{0} entries are imported";
        public const string UI_DATASOURCE_PROGRESS_ENTRIESVALIDATED = "{0} entries are validated";
        public const string UI_DATASOURCE_PROGRESS_RESTORING = "Restoring";
        public const string UI_DATASOURCE_PROGRESS_STARTING = "Starting";
        public const string UI_DATASOURCE_PROGRESS_STRIPPINGATTRS = "Stripping attributes";
        public const string UI_DATASOURCE_PROGRESS_WAITING = "Waiting";
        public const string UI_DATATYPE_DATE = "Date";
        public const string UI_DATATYPE_EXPRESSION = "Expression";
        public const string UI_DATATYPE_INTEGER = "Number (Integer)";
        public const string UI_DATATYPE_LOCALIZEDTEXT = "Text (Localized)";
        public const string UI_DATATYPE_LOGICAL = "Logical";
        public const string UI_DATATYPE_NUMBER = "Number";
        public const string UI_DATATYPE_OBJECT = "Object";
        public const string UI_DATATYPE_OBJECTLIST = "List of Objects";
        public const string UI_DATATYPE_REFERENCE = "Reference";
        public const string UI_DATATYPE_REFERENCELIST = "List of References";
        public const string UI_DATATYPE_TEXT = "Text";
        public const string UI_DATATYPE_TIME = "Time";
        public const string UI_EXPORTPANEL_ATTRIBUTESFIELDLABEL = "Attributes (optional)";
        public const string UI_EXPORTPANEL_ENTITIESFIELDSET = "Entities";
        public const string UI_EXPORTPANEL_EXPORTBUTTON = "Export";
        public const string UI_EXPORTPANEL_TITLE = "Export";
        public const string UI_EXPRESSIONFIELD_EMPTYTEXT = "Expression can't be empty string.";
        public const string UI_FORMPANEL_ACTIONSBUTTONGROUP = "Actions";
        public const string UI_FORMPANEL_CLONEBUTTON = "Clone";
        public const string UI_FORMPANEL_CONFIRMCLOSEWITHCHANGESTEXT = "There is unsaved changes. Discard it?";
        public const string UI_FORMPANEL_CONFIRMCLOSEWITHCHANGESTITLE = "Unsaved changes";
        public const string UI_FORMPANEL_CONFIRMDELETETEXT = "Do you really want to delete this entry?'";
        public const string UI_FORMPANEL_CONFIRMDELETETITLE = "Delete";
        public const string UI_FORMPANEL_DELETEBUTTON = "Delete";
        public const string UI_FORMPANEL_DELETEFAILEDTEXT = "Delete failed.";
        public const string UI_FORMPANEL_DELETESUCCESSTEXT = "Deleted successully.";
        public const string UI_FORMPANEL_DELETINGPROGRESS = "Deleting...";
        public const string UI_FORMPANEL_DISCARDBUTTON = "Discard";
        public const string UI_FORMPANEL_LOADINGPROGRESS = "Loading...";
        public const string UI_FORMPANEL_PUBLISHBUTTON = "Publish";
        public const string UI_FORMPANEL_RELOADBUTTON = "Reload";
        public const string UI_FORMPANEL_SAVEANDCLOSEBUTTON = "Save & Close";
        public const string UI_FORMPANEL_SAVEBUTTON = "Save";
        public const string UI_FORMPANEL_SAVEFAILEDTEXT = "Changes are not saved because of errors.";
        public const string UI_FORMPANEL_SAVESUCCESSTEXT = "Saved successully.";
        public const string UI_FORMPANEL_SAVINGPROGRESS = "Saving...";
        public const string UI_FORMPANEL_UNPUBLISHBUTTON = "Unpublish";
        public const string UI_GRIDPANEL_ACTIONSBUTTONGROUP = "Actions";
        public const string UI_GRIDPANEL_BULKBUTTONGROUP = "Bulk";
        public const string UI_GRIDPANEL_CLONEBUTTON = "Clone";
        public const string UI_GRIDPANEL_CONFIRMDELETETEXT = "Confirm deletion of these entries";
        public const string UI_GRIDPANEL_CREATEBUTTON = "Create";
        public const string UI_GRIDPANEL_DELETEBUTTON = "Delete";
        public const string UI_GRIDPANEL_DELETINGPROGRESS = "Deleting entries...";
        public const string UI_GRIDPANEL_DESIGNBUTTON = "Design";
        public const string UI_GRIDPANEL_UNPUBLISHBUTTON = "Unpublish";
        public const string UI_GRIDPANEL_DISABLINGPROGRESS = "Un-publishing...";
        public const string UI_GRIDPANEL_EDITBUTTON = "Edit";
        public const string UI_GRIDPANEL_PUBLISHBUTTON = "Publish";
        public const string UI_GRIDPANEL_ENABLINGPROGRESS = "Publishing...";
        public const string UI_GRIDPANEL_EXPORTBUTTON = "Export";
        public const string UI_GRIDPANEL_IMPORTBUTTON = "Import";
        public const string UI_GRIDPANEL_METADATABUTTONGROUP = "Metadata";
        public const string UI_GRIDPANEL_SEARCHPLACEHOLDER = "Type here to search";
        public const string UI_IDGENERATOR_CUSTOM = "Custom";
        public const string UI_IDGENERATOR_GLOBALSEQUENCE = "Numeric Sequence (Global)";
        public const string UI_IDGENERATOR_GUID = "GUID";
        public const string UI_IDGENERATOR_OBJECTID = "BSON ObjectId";
        public const string UI_IDGENERATOR_SEQUENCE = "Numeric Sequence";
        public const string UI_IMPORTPANEL_ENTITIESFIELDSET = "Entities";
        public const string UI_IMPORTPANEL_FILEFIELDLABEL = "File";
        public const string UI_IMPORTPANEL_IMPORTBUTTON = "Import";
        public const string UI_IMPORTPANEL_MODECREATEANDUPDATE = "Create and Update";
        public const string UI_IMPORTPANEL_MODEFIELDLABEL = "Mode";
        public const string UI_IMPORTPANEL_MODEREPLACE = "Replace whole collection";
        public const string UI_IMPORTPANEL_MODEUPDATE = "Update";
        public const string UI_IMPORTPANEL_MODEUPDATEONLY = "Update (without changing structure)";
        public const string UI_IMPORTPANEL_TITLE = "Import";
        public const string UI_IMPORTPANEL_UPLOADINGPROGRESS = "Uploading...";
        public const string UI_OBJECTLISTFIELD_CLONEBUTTON = "Clone";
        public const string UI_OBJECTLISTFIELD_MOVEDOWNBUTTON = "Move down";
        public const string UI_OBJECTLISTFIELD_MOVEUPBUTTON = "Move up";
        public const string UI_OBJECTLISTFIELD_REMOVEBUTTON = "Remove";
        public const string UI_PROCESSEXECUTIONSTATUS_CANCELED = "Canceled";
        public const string UI_PROCESSEXECUTIONSTATUS_COMPLETED = "Completed";
        public const string UI_PROCESSEXECUTIONSTATUS_CREATED = "Created";
        public const string UI_PROCESSEXECUTIONSTATUS_FAULTED = "Faulted";
        public const string UI_PROCESSEXECUTIONSTATUS_RUNNING = "Running";
        public const string UI_PROCESSEXECUTIONSTATUS_WAITINGFORACTIVATION = "Waiting For Activation";
        public const string UI_PROCESSEXECUTIONSTATUS_WAITINGFORCHILDRENTOCOMPLETE = "Waiting For Children";
        public const string UI_PROCESSEXECUTIONSTATUS_WAITINGTORUN = "Waiting To Run";
        public const string UI_PROCESSPANEL_DOWNLOADFIELDLABEL = "Download";
        public const string UI_PROCESSPANEL_ERRORFIELDLABEL = "Error";
        public const string UI_PROCESSPANEL_EXECUTIONTIMEFIELDLABEL = "Execution Time (Ms)";
        public const string UI_PROCESSPANEL_IDFIELDLABEL = "Id";
        public const string UI_PROCESSPANEL_INVOKERFIELDLABEL = "Invoker";
        public const string UI_PROCESSPANEL_PROGRESSFIELDLABEL = "Progress";
        public const string UI_PROCESSPANEL_STATUSFIELDLABEL = "Status";
        public const string UI_PROCESSPANEL_TYPEFIELDLABEL = "Type";
        public const string UI_PROCESSTYPE_BACKUP = "Backup";
        public const string UI_PROCESSTYPE_EXPORT = "Export";
        public const string UI_PROCESSTYPE_IMPORT = "Import";
        public const string UI_PROCESSTYPE_MIGRATION = "Migration";
        public const string UI_PROCESSTYPE_RESTORE = "Restore";
        public const string UI_PROCESSTYPE_VALIDATION = "Validation";
        public const string UI_REQUIREMENT_NONE = "Not Required";
        public const string UI_REQUIREMENT_RECOMMENDED = "Recommended";
        public const string UI_REQUIREMENT_REQUIRED = "Required";
        public const string UI_RESTOREPANEL_CLOSEBUTTON = "Close";
        public const string UI_RESTOREPANEL_FILEFIELDLABEL = "File";
        public const string UI_RESTOREPANEL_RESTOREBUTTON = "Restore";
        public const string UI_RESTOREPANEL_TITLE = "Restore";
        public const string UI_RESTOREPANEL_UPLOADINGPROGRESS = "Uploading...";
        public const string UI_SPECIFICATIONWINDOW_ALLOWGROWFIELDLABEL = "Allow to grow?";
        public const string UI_SPECIFICATIONWINDOW_CANCELBUTTON = "Cancel";
        public const string UI_SPECIFICATIONWINDOW_EDITORFIELDLABEL = "Editor";
        public const string UI_SPECIFICATIONWINDOW_EDITOR_MULTILINETEXTBOX = "Multiline Text Box";
        public const string UI_SPECIFICATIONWINDOW_EDITOR_TEXTBOX = "Text Box";
        public const string UI_SPECIFICATIONWINDOW_ICONFIELDLABEL = "Icon";
        public const string UI_SPECIFICATIONWINDOW_KINDFIELDDESCRIPTION = "<strong>Sub-Entity</strong> - implies that the entity is always embedded in another entity.<br/><strong>Settings</strong> - implies that there is only one instance of this entity.";
        public const string UI_SPECIFICATIONWINDOW_KINDFIELDLABEL = "Kind";
        public const string UI_SPECIFICATIONWINDOW_KIND_NORMAL = "Normal";
        public const string UI_SPECIFICATIONWINDOW_KIND_SETTINGS = "Settings";
        public const string UI_SPECIFICATIONWINDOW_KIND_SUBENTITY = "Sub-Entity";
        public const string UI_SPECIFICATIONWINDOW_NAMEFIELDLABEL = "Name";
        public const string UI_SPECIFICATIONWINDOW_PARAMETERFIELDLABEL = "Parameter";
        public const string UI_SPECIFICATIONWINDOW_RESULTFIELDLABEL = "Result";
        public const string UI_SPECIFICATIONWINDOW_SAVEBUTTON = "Save";
        public const string UI_SPECIFICATIONWINDOW_SKIPCODEGENFIELDDESCRIPTION = "Don' generate class/struct during code generation and skip it during deserialization.";
        public const string UI_SPECIFICATIONWINDOW_SKIPCODEGENFIELDLABEL = "Skip codegen?";
        public const string UI_SPECIFICATIONWINDOW_SUBTYPEFIELDLABEL = "Sub-Type";
        public const string UI_SPECIFICATIONWINDOW_SUBTYPE_FLAGS = "Flags";
        public const string UI_SPECIFICATIONWINDOW_SUBTYPE_NONE = "None";
        public const string UI_SPECIFICATIONWINDOW_SUBTYPE_PICKLIST = "Picklist";
        public const string UI_SPECIFICATIONWINDOW_TYPEFIELDLABEL = "Type";
        public const string UI_TABPANEL_CLOSEALLTABS = "Close All Tabs";
        public const string UI_TABPANEL_CLOSEOTHERTABS = "Close Other Tabs";
        public const string UI_TABPANEL_CLOSETAB = "Close Tab";
        public const string UI_UNIQUENESS_NONE = "Not Unique";
        public const string UI_UNIQUENESS_UNIQUE = "Unique";
        public const string UI_UNIQUENESS_UNIQUEINCONTAINER = "Unique for Container";
        public const string UI_VALIDATIONERRORTYPE_BROKENREFERENCE = "Broken Reference";
        public const string UI_VALIDATIONERRORTYPE_DUPLICATEIDATTRIBUTE = "Duplicate ID Value";
        public const string UI_VALIDATIONERRORTYPE_DUPLICATEUNIQUEATTRIBUTE = "Duplicate Value";
        public const string UI_VALIDATIONERRORTYPE_ENTRYNOTFOUND = "Find Failure";
        public const string UI_VALIDATIONERRORTYPE_EXCEPTION = "Error";
        public const string UI_VALIDATIONERRORTYPE_INVALIDVALUE = "Invalid Value";
        public const string UI_VALIDATIONERRORTYPE_MISSINGLOCALIZATION = "Missing Localization Value";
        public const string UI_VALIDATIONERRORTYPE_MISSINGREQUIREDVALUE = "Missing Value";
        public const string UI_VALIDATIONERRORTYPE_OPTIMISTICCONCURRENCYFAIL = "Update Failure";
        public const string UI_VALIDATIONERRORTYPE_REFERENCINGDISABLED = "Invalid Reference";
        public const string UI_VALIDATIONERRORTYPE_REFERENCINGUNPUBLISHED = "Value is referencing to un-published '{0}'.";
        public const string UI_XLSX_ENTITYCOLUMN = "Entity";
        public const string UI_XLSX_ENTRYIDCOLUMN = "Entry Id";
        public const string UI_XLSX_ERRORCOLUMN = "Error";
        public const string UI_XLSX_ERRORSHEET = "Error";
        public const string UI_XLSX_HRESULTCOLUMN = "HResult";
        public const string UI_XLSX_IMPORTREPORTSHEET = "Import Report";
        public const string UI_XLSX_MESSAGECOLUMN = "Message";
        public const string UI_XLSX_NEWENTRYIDCOLUMN = "New Entry Id";
        public const string UI_XLSX_PATHCOLUMN = "Path";
        public const string UI_XLSX_STACKTRACECOLUMN = "Stack";
        public const string UI_XLSX_TYPECOLUMN = "Type";
        public const string UI_XLSX_VALIDATIONREPORTSHEET = "Validation Report";
        public const string UI_PROGRAM_LISTENINGAT = "Listening at address: {0}";
        public const string UI_OBJECTLIST_ADDBUTTON = "Add {0}";
        public const string UI_UNITYPLUGIN_GENERATEASSETCANTFINDGAMEDATACLASS = "Asset generation failed: unable to find GameData's type in CSharp assemblies. Make sure there is no compilation errors.";
        public const string UI_UNITYPLUGIN_GENERATECODEFOR = "Running generation tools for {0}";
        public const string UI_UNITYPLUGIN_GENERATEFAILEDDUEERRORS = "Code generation for '{0}' failed due errors: {1}.";
        public const string UI_UNITYPLUGIN_GENERATEREFORMATCODE = "Re-formatting generated code for {0}";
        public const string UI_UNITYPLUGIN_GENERATEREFRESHINGASSETS = "Refreshing assets";
        public const string UI_UNITYPLUGIN_GENERATINGCODEANDASSETS = "Generating Code and Assets...";
        public const string UI_UNITYPLUGIN_MENUSCANNINGASSETS = "Scanning Assets...";
        public const string UI_UNITYPLUGIN_MIGRATECOMPLETE = "Migration of '{0}' is complete.";
        public const string UI_UNITYPLUGIN_MIGRATEFAILEDDUEERRORS = "Migration of '{0}' has failed due errors: {1}.";
        public const string UI_UNITYPLUGIN_MIGRATERUNMIGRATIONFOR = "Running migration tools for {0}";
        public const string UI_UNITYPLUGIN_MIGRATINGASSETS = "Migrating Assets...";
        public const string UI_UNITYPLUGIN_PROGRESSCURRENTTARGETIS = "Current target is {0}";
        public const string UI_UNITYPLUGIN_PROGRESSDONE = "Done";
        public const string UI_UNITYPLUGIN_SCANASSETSKIPPED = "TextAsset '{0}' is skipped because of validation error.";
        public const string UI_UNITYPLUGIN_SCANCOMPLETE = "Scan complete: {0} files are located. Total {1} files are tracked.";
        public const string UI_UNITYPLUGIN_SCANRUNVALIDATIONFOR = "Running validation tool for {0}";
        public const string UI_UNITYPLUGIN_SPECIFYEXTRACTIONLOCTITLE = "Specify extraction location...";
        public const string UI_UNITYPLUGIN_T4EXTRACTIONCOMPLETE = "T4 Template extracted successfully.";
        public const string UI_UNITYPLUGIN_T4EXTRACTIONFAILED = "T4 Template extraction failed due errors: {0}";
        public const string UI_UNITYPLUGIN_VALIDATECOMPLETE = "Validation of '{0}' is complete. Result: {1}, Errors: {2}.";
        public const string UI_UNITYPLUGIN_VALIDATEFAILEDDUEERRORS = "Validation of '{0}' has failed due errors: {1}.";
        public const string UI_UNITYPLUGIN_VALIDATERUNFOR = "Running validation tool for {0}";
        public const string UI_UNITYPLUGIN_VALIDATINGASSETS = "Validating Assets...";
        public const string UI_UNITYPLUGIN_MENUABOUT = "About...";
        public const string UI_UNITYPLUGIN_MENUDOCUMENTATION = "Documentation (website)";
        public const string UI_UNITYPLUGIN_MENUEXTRACTT4TEMPLATES = "Extract T4 Templates";
        public const string UI_UNITYPLUGIN_MENUGENERATECODEANDASSETS = "Generate Code and Assets";
        public const string UI_UNITYPLUGIN_MENUMIGRATEASSETS = "Migrate Assets";
        public const string UI_UNITYPLUGIN_MENURECOVERYSCRIPTS = "Recovery Scripts";
        public const string UI_UNITYPLUGIN_MENUSCANFORNEWASSETS = "Scan for new Assets";
        public const string UI_UNITYPLUGIN_MENUSUBMITISSUE = "Submit an Issue (website)";
        public const string UI_UNITYPLUGIN_MENUTROUBLESHOOTING = "Troubleshooting";
        public const string UI_UNITYPLUGIN_MENUVALIDATEASSETS = "Validate Assets";
        public const string UI_UNITYPLUGIN_MENUVERBOSELOGS = "Verbose Logs";
        public const string UI_UNITYPLUGIN_OPERATIONCANCELLED = "Operation was cancelled by user.";
        public const string UI_UNITYPLUGIN_WINDOWABOUTCHARONTITLE = "Charon: Game Data Editor";
        public const string UI_UNITYPLUGIN_WINDOWACTIONSGROUP = "Actions";
        public const string UI_UNITYPLUGIN_WINDOWASSETGENERATIONPATH = "Asset Generation Path";
        public const string UI_UNITYPLUGIN_WINDOWAUTOGENERATION = "Auto-Generation";
        public const string UI_UNITYPLUGIN_WINDOWBROWSEBUTTON = "Browse...";
        public const string UI_UNITYPLUGIN_WINDOWBROWSER = "Browser";
        public const string UI_UNITYPLUGIN_WINDOWBROWSERPATH = "Browser Path";
        public const string UI_UNITYPLUGIN_WINDOWBROWSERPATHTITLE = "Path to browser application";
        public const string UI_UNITYPLUGIN_WINDOWCANCELBUTTON = "Cancel";
        public const string UI_UNITYPLUGIN_WINDOWCHECKINGMONO = "Checking Mono...";
        public const string UI_UNITYPLUGIN_WINDOWCHECKINGMONOFAILED = "Mono doesn't return any version information. Exit code: {0}";
        public const string UI_UNITYPLUGIN_WINDOWCHECKINGVERSION = "Checking...";
        public const string UI_UNITYPLUGIN_WINDOWCHECKRESULTMISSINGMONOORDOTNET = "Missing .NET Runtime!";
        public const string UI_UNITYPLUGIN_WINDOWCHECKRESULTMISSINGTOOLS = "Missing Tools!";
        public const string UI_UNITYPLUGIN_WINDOWCODEENTRYCLASSNAME = "Code Entry class";
        public const string UI_UNITYPLUGIN_WINDOWCODEGAMEDATACLASSNAME = "Code GameData class";
        public const string UI_UNITYPLUGIN_WINDOWCODEGENERATIONPATH = "Code Generation Path";
        public const string UI_UNITYPLUGIN_WINDOWCODEGENERATOR = "Code Generator";
        public const string UI_UNITYPLUGIN_WINDOWCODEIDENTATION = "Identation";
        public const string UI_UNITYPLUGIN_WINDOWCODELINEENDINGS = "Line endings";
        public const string UI_UNITYPLUGIN_WINDOWCODENAMESPACE = "Code Namespace";
        public const string UI_UNITYPLUGIN_WINDOWCODEOPTIONS = "Options";
        public const string UI_UNITYPLUGIN_WINDOWDOWNLOADDOTNET = "c) Or you can download  .NET 4.5 by pressing 'Download .NET 4.5'.";
        public const string UI_UNITYPLUGIN_WINDOWDOWNLOADDOTNETBUTTON = "Download .NET 4.5";
        public const string UI_UNITYPLUGIN_WINDOWDOWNLOADMONO = "b) If it doesn't exists you can press 'Download Mono' button below and try again.";
        public const string UI_UNITYPLUGIN_WINDOWDOWNLOADMONOBUTTON = "Download Mono";
        public const string UI_UNITYPLUGIN_WINDOWEDITBUTTON = "Edit";
        public const string UI_UNITYPLUGIN_WINDOWEDITORISOPENED = "Browser is currently opened for '{0}'. Close this window after you finished work.";
        public const string UI_UNITYPLUGIN_WINDOWEDITORLOADING = "Please wait while Game Data Editor is loading...";
        public const string UI_UNITYPLUGIN_WINDOWEDITORTITLE = "Editor";
        public const string UI_UNITYPLUGIN_WINDOWEDITORWASCRASHED = "Game Data Editor has crashed :(";
        public const string UI_UNITYPLUGIN_WINDOWFAILEDTOSTARTEDITOR = "Failed to start Game Data editor due errors:";
        public const string UI_UNITYPLUGIN_WINDOWFAILEDTOSTARTEDITORTIMEOUT = "Failed to start Game Data editor due errors: Aborted by timeout.";
        public const string UI_UNITYPLUGIN_WINDOWFINDMONOMANUALLY = "a) You can manually locate Mono Runtime by pressing 'Browse...' button.";
        public const string UI_UNITYPLUGIN_WINDOWGENERATIONPREFIX = "Generation:";
        public const string UI_UNITYPLUGIN_WINDOWHELPBUTTON = "Help";
        public const string UI_UNITYPLUGIN_WINDOWIMPORTLICENSEBUTTON = "Import";
        public const string UI_UNITYPLUGIN_WINDOWINFOGROUP = "Info:";
        public const string UI_UNITYPLUGIN_WINDOWLICENSEHOLDER = "License Holder";
        public const string UI_UNITYPLUGIN_WINDOWLICENSEKEY = "License Key";
        public const string UI_UNITYPLUGIN_WINDOWLOADINGFAILEDWITHERROR = "Loading failed with error: {0}";
        public const string UI_UNITYPLUGIN_WINDOWMIGRATEBUTTON = "Migrate";
        public const string UI_UNITYPLUGIN_WINDOWMIGRATIONPREFIX = "Migration:";
        public const string UI_UNITYPLUGIN_WINDOWOKBUTTON = "Ok";
        public const string UI_UNITYPLUGIN_WINDOWPATHTOMONO = "Path to Mono (bin)";
        public const string UI_UNITYPLUGIN_WINDOWPRESSHELP = "If you need a help with .NET Runtime installation press 'Help' button.";
        public const string UI_UNITYPLUGIN_WINDOWRECHECKBUTTON = "Re-check";
        public const string UI_UNITYPLUGIN_WINDOWRELOADBUTTON = "Reload";
        public const string UI_UNITYPLUGIN_WINDOWRESUMECODERECOMPILATION = "Resume code re-compilation?";
        public const string UI_UNITYPLUGIN_WINDOWRUNGENERATORBUTTON = "Run Generator";
        public const string UI_UNITYPLUGIN_WINDOWRUNTIMEREQUIRED = "To run Game Data Editor and related tools you need a installed .NET Runtime or Mono Runtime.";
        public const string UI_UNITYPLUGIN_WINDOWRUNTIMEVERSION = "Runtime Version";
        public const string UI_UNITYPLUGIN_WINDOWRUNTIMEVERSIONERROR = "Error";
        public const string UI_UNITYPLUGIN_WINDOWRUNTIMEVERSIONUNKNOWN = "Unknown";
        public const string UI_UNITYPLUGIN_WINDOWSETTINGSGROUP = "Settings:";
        public const string UI_UNITYPLUGIN_WINDOWTOOLSPATH = "Tools Path";
        public const string UI_UNITYPLUGIN_WINDOWTOOLSPORT = "Tools Port";
        public const string UI_UNITYPLUGIN_WINDOWTOOLSVERSIONLABEL = "Tools Version";
        public const string UI_UNITYPLUGIN_WINDOWUNTRACTBUTTON = "Untrack";
        public const string UI_UNITYPLUGIN_WINDOWUPDATERUNTIMETITLE = ".NET Runtime Update";
        public const string UI_UNITYPLUGIN_WINDOWUPDATETOOLSTITLE = "Tools Update";
        public const string UI_UNITYPLUGIN_WINDOWVALIDATEBUTTON = "Validate";
        public const string UI_UNITYPLUGIN_WINDOWVALIDATIONPREFIX = "Validation:";
    }
#endif
}

