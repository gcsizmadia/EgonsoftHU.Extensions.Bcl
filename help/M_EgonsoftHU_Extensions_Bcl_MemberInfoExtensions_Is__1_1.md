# Is&lt;TMemberType&gt;(MemberInfo, String, StringComparison) Method


Indicates whether a member has the specified type and name.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static bool Is<TMemberType>(
	this MemberInfo member,
	string memberName,
	StringComparison stringComparison = 4
)

```
**VB**
``` VB
<ExtensionAttribute>
Public Shared Function Is(Of TMemberType) ( 
	member As MemberInfo,
	memberName As String,
	Optional stringComparison As StringComparison = 4
) As Boolean
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.reflection.memberinfo" target="_blank" rel="noopener noreferrer">MemberInfo</a></dt><dd>The member to test.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The expected name of the member.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.stringcomparison" target="_blank" rel="noopener noreferrer">StringComparison</a>  (Optional)</dt><dd>The string comparison mode for <em>memberName</em> parameter.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The expected member type.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if member type and name meet the expectations; otherwise, false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://learn.microsoft.com/dotnet/api/system.reflection.memberinfo" target="_blank" rel="noopener noreferrer">MemberInfo</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">

Extension Methods (C# Programming Guide)</a>.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td>Either <em>member</em> or <em>memberName</em> is null.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td>
<td><em>memberName</em> is <a href="https://learn.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a> or consists only of white-space characters.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_MemberInfoExtensions.md">MemberInfoExtensions Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_MemberInfoExtensions_Is.md">Is Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
