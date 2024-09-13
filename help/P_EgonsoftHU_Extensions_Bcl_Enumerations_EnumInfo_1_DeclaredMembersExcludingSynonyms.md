# DeclaredMembersExcludingSynonyms Property


Gets a collection of the fields defined by the *TEnum* type, each represented by an instance of the <a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum)</a> type.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static IReadOnlyCollection<EnumInfo<TEnum>> DeclaredMembersExcludingSynonyms { get; }
```
**VB**
``` VB
Public Shared ReadOnly Property DeclaredMembersExcludingSynonyms As IReadOnlyCollection(Of EnumInfo(Of TEnum))
	Get
```



#### Property Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" rel="noopener noreferrer">IReadOnlyCollection</a>(<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo</a>(<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">TEnum</a>))

## Remarks
If multiple constants of type *TEnum* have the same value, only one of them (the first in the order of declaration) is included in the collection.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Enumerations_EnumInfo_1.md">EnumInfo(TEnum) Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Enumerations.md">EgonsoftHU.Extensions.Bcl.Enumerations Namespace</a>  