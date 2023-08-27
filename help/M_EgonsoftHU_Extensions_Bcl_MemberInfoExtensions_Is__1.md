# MemberInfoExtensions.Is(*TMemberType*) Method (MemberInfo)
 

Indicates whether a member has the specified type.

**Namespace:**&nbsp;<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a><br />**Assembly:**&nbsp;EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 2.1.0+c3dc2893f0812c87b63b366f67c4cfb5c4234bd9

## Syntax

**C#**<br />
``` C#
public static bool Is<TMemberType>(
	this MemberInfo member
)

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Is(Of TMemberType) ( 
	member As MemberInfo
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>member</dt><dd>Type: <a href="https://learn.microsoft.com/dotnet/api/system.reflection.memberinfo" target="_blank" rel="noopener noreferrer">System.Reflection.MemberInfo</a><br />The member to test.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TMemberType</dt><dd>The expected member type.</dd></dl>

#### Return Value
Type: <a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a><br />`true` (`True` in Visual Basic) if member type meets the expectation; otherwise, `false` (`False` in Visual Basic).

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.reflection.memberinfo" target="_blank" rel="noopener noreferrer">MemberInfo</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td><td>*member* is a null reference (`Nothing` in Visual Basic).</td></tr></table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_MemberInfoExtensions.md">MemberInfoExtensions Class</a><br /><a href="Overload_EgonsoftHU_Extensions_Bcl_MemberInfoExtensions_Is.md">Is Overload</a><br /><a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a><br />