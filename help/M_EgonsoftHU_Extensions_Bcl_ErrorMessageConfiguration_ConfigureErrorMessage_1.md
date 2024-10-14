# ConfigureErrorMessage(String, Type, String) Method


Replaces the default error message for the error specified by *errorMessageKey* using resource.



## Definition
**Namespace:** <a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl</a>  
**Assembly:** EgonsoftHU.Extensions.Bcl (in EgonsoftHU.Extensions.Bcl.dll) Version: 3.0.1+8c729d04d0fcab10705485e5626d4fdebeaa818d

**C#**
``` C#
public void ConfigureErrorMessage(
	string errorMessageKey,
	Type errorMessageResourceType,
	string? errorMessageResourceName = null
)
```
**VB**
``` VB
Public Sub ConfigureErrorMessage ( 
	errorMessageKey As String,
	errorMessageResourceType As Type,
	Optional errorMessageResourceName As String = Nothing
)
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The key that identifies an error message.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a></dt><dd>The resource type to use for error message lookups.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  (Optional)</dt><dd>The resource name (property name) to use as the key for lookups on the resource type.</dd></dl>

## Remarks
This method is intended to be used for localizable error messages.  
 Use <a href="M_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage.md">ConfigureErrorMessage(String, String)</a> for non-localized error messages. 
If *errorMessageResourceName* is null, <a href="https://learn.microsoft.com/dotnet/api/system.string.empty" target="_blank" rel="noopener noreferrer">Empty</a>, or if *errorMessageResourceName* consists exclusively of white-space characters then the value of *errorMessageKey* will be used.


## See Also


#### Reference
<a href="T_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration.md">ErrorMessageConfiguration Class</a>  
<a href="Overload_EgonsoftHU_Extensions_Bcl_ErrorMessageConfiguration_ConfigureErrorMessage.md">ConfigureErrorMessage Overload</a>  
<a href="N_EgonsoftHU_Extensions_Bcl.md">EgonsoftHU.Extensions.Bcl Namespace</a>  
