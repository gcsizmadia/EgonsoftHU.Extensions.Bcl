# StringSyntaxAttribute Class


Specifies the syntax used in a string.



## Definition
**Namespace:** <a href="N_System_Diagnostics_CodeAnalysis.md">System.Diagnostics.CodeAnalysis</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public sealed class StringSyntaxAttribute : Attribute
```
**VB**
``` VB
Public NotInheritable Class StringSyntaxAttribute
	Inherits Attribute
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>  →  StringSyntaxAttribute</td></tr>
</table>



## Constructors
<table>
<tr>
<td><a href="M_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute__ctor.md">StringSyntaxAttribute(String)</a></td>
<td>Initializes the StringSyntaxAttribute with the identifier of the syntax used.</td></tr>
<tr>
<td><a href="M_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute__ctor_1.md">StringSyntaxAttribute(String, Object[])</a></td>
<td>Initializes the StringSyntaxAttribute with the identifier of the syntax used.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_Arguments.md">Arguments</a></td>
<td>Gets the optional arguments associated with the specific syntax employed.</td></tr>
<tr>
<td><a href="P_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_Syntax.md">Syntax</a></td>
<td>Gets the identifier of the syntax used.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.typeid" target="_blank" rel="noopener noreferrer">TypeId</a></td>
<td>When implemented in a derived class, gets a unique identifier for this <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.equals" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Returns a value that indicates whether this instance is equal to a specified object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Returns the hash code for this instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.isdefaultattribute" target="_blank" rel="noopener noreferrer">IsDefaultAttribute</a></td>
<td>When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.match" target="_blank" rel="noopener noreferrer">Match</a></td>
<td>When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_CompositeFormat.md">CompositeFormat</a></td>
<td>The syntax identifier for strings containing composite formats for string formatting.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_DateOnlyFormat.md">DateOnlyFormat</a></td>
<td>The syntax identifier for strings containing date format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_DateTimeFormat.md">DateTimeFormat</a></td>
<td>The syntax identifier for strings containing date and time format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_EnumFormat.md">EnumFormat</a></td>
<td>The syntax identifier for strings containing <a href="https://learn.microsoft.com/dotnet/api/system.enum" target="_blank" rel="noopener noreferrer">Enum</a> format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_GuidFormat.md">GuidFormat</a></td>
<td>The syntax identifier for strings containing <a href="https://learn.microsoft.com/dotnet/api/system.guid" target="_blank" rel="noopener noreferrer">Guid</a> format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_Json.md">Json</a></td>
<td>The syntax identifier for strings containing JavaScript Object Notation (JSON).</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_NumericFormat.md">NumericFormat</a></td>
<td>The syntax identifier for strings containing numeric format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_Regex.md">Regex</a></td>
<td>The syntax identifier for strings containing regular expressions.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_TimeOnlyFormat.md">TimeOnlyFormat</a></td>
<td>The syntax identifier for strings containing time format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_TimeSpanFormat.md">TimeSpanFormat</a></td>
<td>The syntax identifier for strings containing <a href="https://learn.microsoft.com/dotnet/api/system.timespan" target="_blank" rel="noopener noreferrer">TimeSpan</a> format specifiers.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_Uri.md">Uri</a></td>
<td>The syntax identifier for strings containing URIs.</td></tr>
<tr>
<td><a href="F_System_Diagnostics_CodeAnalysis_StringSyntaxAttribute_Xml.md">Xml</a></td>
<td>The syntax identifier for strings containing XML.</td></tr>
</table>

## Explicit Interface Implementations
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.system-runtime-interopservices-_attribute-getidsofnames" target="_blank" rel="noopener noreferrer">System#Runtime#InteropServices#_Attribute#GetIDsOfNames</a></td>
<td><br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.system-runtime-interopservices-_attribute-gettypeinfo" target="_blank" rel="noopener noreferrer">System#Runtime#InteropServices#_Attribute#GetTypeInfo</a></td>
<td><br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.system-runtime-interopservices-_attribute-gettypeinfocount" target="_blank" rel="noopener noreferrer">System#Runtime#InteropServices#_Attribute#GetTypeInfoCount</a></td>
<td><br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.attribute.system-runtime-interopservices-_attribute-invoke" target="_blank" rel="noopener noreferrer">System#Runtime#InteropServices#_Attribute#Invoke</a></td>
<td><br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.attribute" target="_blank" rel="noopener noreferrer">Attribute</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_System_Diagnostics_CodeAnalysis.md">System.Diagnostics.CodeAnalysis Namespace</a>  
