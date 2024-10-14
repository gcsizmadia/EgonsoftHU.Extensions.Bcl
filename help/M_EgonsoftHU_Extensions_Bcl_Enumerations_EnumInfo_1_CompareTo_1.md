# CompareTo(Object) Method


Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public int CompareTo(
	Object? obj
)
```
**VB**
``` VB
Public Function CompareTo ( 
	obj As Object
) As Integer
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a></dt><dd>An object to compare with this instance.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a>  
A value that indicates the relative order of the objects being compared. The return value has these meanings: <table><thead><tr><th>Value</th><th>Meaning</th></tr></thead><tr><td>Less than zero</td><td>This instance precedes <em>obj</em> in the sort order.</td></tr><tr><td>Zero</td><td>This instance occurs in the same position in the sort order as <em>obj</em>.</td></tr><tr><td>Greater than zero</td><td>This instance follows <em>obj</em> in the sort order.</td></tr></table>



#### Implements
<a href="https://learn.microsoft.com/dotnet/api/system.icomparable.compareto" target="_blank" rel="noopener noreferrer">IComparable.CompareTo(Object)</a>  


## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentexception" target="_blank" rel="noopener noreferrer">ArgumentException</a></td>
<td><em>obj</em> is not the same type as this instance.</td></tr>
</table>

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum) Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1_CompareTo.md">CompareTo Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  
