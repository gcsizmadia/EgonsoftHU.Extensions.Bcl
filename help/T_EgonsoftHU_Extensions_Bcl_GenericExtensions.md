# GenericExtensions Class
 

This class contains generic extension methods that are available for any type.


## Inheritance Hierarchy
<a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;EgonsoftHU.Extensions.Bcl.GenericExtensions<br />
**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static class GenericExtensions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class GenericExtensions
```

The GenericExtensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_AsEnumerable__1.md">AsEnumerable(T)</a></td><td> **Obsolete. **
Returns a value as a sequence that contains only that value.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_AsSingleElementSequence__1.md">AsSingleElementSequence(T)</a></td><td>
Returns a value as a sequence that contains only that value.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_GetPropertyValue__1.md">GetPropertyValue(TSource)</a></td><td>
Gets the value of an instance property of the source object using reflection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_GetStringValueOrEmptyString__1.md">GetStringValueOrEmptyString(TSource)</a></td><td>
Gets a string value using a specified value selector or <a href="https://learn.microsoft.com/dotnet/api/system.string.empty#system-string-empty" target="_blank" rel="noopener noreferrer">Empty</a>. The value selector gets the source object as input parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_GetStringValueOrNull__1.md">GetStringValueOrNull(TSource)</a></td><td>
Gets a string value using a specified value selector or null. The value selector gets the source object as input parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_GetValue__2.md">GetValue(TSource, TResult)</a></td><td>
Gets a value using a specified value selector that gets the source object as input parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_GetValueOrDefault__2.md">GetValueOrDefault(TSource, TResult)</a></td><td>
Gets a value using a specified value selector or a specified default value. The value selector gets the source object as input parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsDefaultValue__1.md">IsDefaultValue(T)</a></td><td>
Determines whether a specified *value* is the default value of its <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsIn__1_1.md">IsIn(T)(T, T[])</a></td><td>
Determines whether a specified collection contains the current value by using the default equality comparer.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsIn__1.md">IsIn(T)(T, IEqualityComparer(T), T[])</a></td><td>
Determines whether a specified collection contains the current value by using a specified <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1" target="_blank" rel="noopener noreferrer">IEqualityComparer(T)</a>. If no equality comparer is specified then the default equality comparer will be used.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsNotIn__1_1.md">IsNotIn(T)(T, T[])</a></td><td>
Determines whether a specified collection does not contain the current value by using a specified <a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1" target="_blank" rel="noopener noreferrer">IEqualityComparer(T)</a>. If no equality comparer is specified then the default equality comparer will be used.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_IsNotIn__1.md">IsNotIn(T)(T, IEqualityComparer(T), T[])</a></td><td>
Determines whether a specified collection does not contain the current value by using the default equality comparer.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_SetPropertyValue__1.md">SetPropertyValue(TSource)</a></td><td>
Sets the value of an instance property of the source object using reflection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_TryGetPropertyValue__1.md">TryGetPropertyValue(TSource)</a></td><td>
Gets the value of an instance property of the source object using reflection.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_EgonsoftHU_Extensions_Bcl_GenericExtensions_TrySetPropertyValue__1.md">TrySetPropertyValue(TSource)</a></td><td>
Sets the value of an instance property of the source object using reflection.</td></tr></table>&nbsp;
<a href="#genericextensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />