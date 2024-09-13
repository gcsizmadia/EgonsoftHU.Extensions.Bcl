# UTF8WithoutBOM Property


The UTF-8 encoding without the Unicode byte order mark.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl_Text.md">EgonsoftHU.Extensions.Bcl.Text</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.0+481c3d11ac7f0bce9309a7e968351bc7be32a6e9

**C#**
``` C#
public static Encoding UTF8WithoutBOM { get; }
```
**VB**
``` VB
Public Shared ReadOnly Property UTF8WithoutBOM As Encoding
	Get
```



#### Property Value
<a href="https://learn.microsoft.com/dotnet/api/system.text.encoding" target="_blank" rel="noopener noreferrer">Encoding</a>

## Remarks
<a href="https://learn.microsoft.com/dotnet/api/system.text.utf8encoding.getpreamble" target="_blank" rel="noopener noreferrer">GetPreamble()</a> will return an empty byte array.

## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_Text_EncodingProvider.md">EncodingProvider Class</a>  
<a href="N_EgonsoftHU_Extensions_Bcl_Text.md">EgonsoftHU.Extensions.Bcl.Text Namespace</a>  
