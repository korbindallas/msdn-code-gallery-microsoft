﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1360
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("XmlSample.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add or Delete Attribtues.
        '''</summary>
        Friend ReadOnly Property cmdAddOrDeleteAttributes() As String
            Get
                Return ResourceManager.GetString("cmdAddOrDeleteAttributes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Add or Delete Elements.
        '''</summary>
        Friend ReadOnly Property cmdAddOrDeleteElements() As String
            Get
                Return ResourceManager.GetString("cmdAddOrDeleteElements", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Create XML Programmatically.
        '''</summary>
        Friend ReadOnly Property cmdCreateXML() As String
            Get
                Return ResourceManager.GetString("cmdCreateXML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Determine a Node&apos;s Type.
        '''</summary>
        Friend ReadOnly Property cmdDetermineNodeType() As String
            Get
                Return ResourceManager.GetString("cmdDetermineNodeType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Iterate through all nodes.
        '''</summary>
        Friend ReadOnly Property cmdIterateAllNodes() As String
            Get
                Return ResourceManager.GetString("cmdIterateAllNodes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Retrieve a list of all element nodes.
        '''</summary>
        Friend ReadOnly Property cmdListAllElementNodes() As String
            Get
                Return ResourceManager.GetString("cmdListAllElementNodes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Build a list of all nodes that match a specific tag.
        '''</summary>
        Friend ReadOnly Property cmdListElementsByTag() As String
            Get
                Return ResourceManager.GetString("cmdListElementsByTag", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Load XML File.
        '''</summary>
        Friend ReadOnly Property cmdLoadXmlFile() As String
            Get
                Return ResourceManager.GetString("cmdLoadXmlFile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Load XML from String.
        '''</summary>
        Friend ReadOnly Property cmdLoadXmlString() As String
            Get
                Return ResourceManager.GetString("cmdLoadXmlString", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modify the Value of an Attribute.
        '''</summary>
        Friend ReadOnly Property cmdModifyAttribute() As String
            Get
                Return ResourceManager.GetString("cmdModifyAttribute", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modify the Value of an Element Node.
        '''</summary>
        Friend ReadOnly Property cmdModifyElement() As String
            Get
                Return ResourceManager.GetString("cmdModifyElement", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Navigate to Related Nodes, Once I&apos;ve Found a Node?.
        '''</summary>
        Friend ReadOnly Property cmdNavigateRelatedNodes() As String
            Get
                Return ResourceManager.GetString("cmdNavigateRelatedNodes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Determine the errors that occured when loading an XML file.
        '''</summary>
        Friend ReadOnly Property cmdParseErrors() As String
            Get
                Return ResourceManager.GetString("cmdParseErrors", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Retrieve Attributes of a Node&lt;.
        '''</summary>
        Friend ReadOnly Property cmdRetrieveAttributes() As String
            Get
                Return ResourceManager.GetString("cmdRetrieveAttributes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Get a node by XPath Expression (selectSingleNode).
        '''</summary>
        Friend ReadOnly Property cmdSelectNode() As String
            Get
                Return ResourceManager.GetString("cmdSelectNode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Get nodes by XPath Expression (selectNodes).
        '''</summary>
        Friend ReadOnly Property cmdSelectNodes() As String
            Get
                Return ResourceManager.GetString("cmdSelectNodes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Determine if a node has children.
        '''</summary>
        Friend ReadOnly Property cmdTestForChildNodes() As String
            Get
                Return ResourceManager.GetString("cmdTestForChildNodes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Determine if a file contains Valid XML.
        '''</summary>
        Friend ReadOnly Property cmdValidXml() As String
            Get
                Return ResourceManager.GetString("cmdValidXml", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
