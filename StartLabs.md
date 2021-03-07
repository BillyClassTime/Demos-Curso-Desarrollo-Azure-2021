```
New-Item -Path "D:\" -Name "Allfiles" -ItemType "directory"

Import-Module -Name BitsTransfer

Start-BitsTransfer -Source 'https://github.com/MicrosoftLearning/AZ-204-DevelopingSolutionsforMicrosoftAzure/archive/master.zip' -Destination D:\Allfiles

Expand-Archive -Path 'D:\Allfiles\master.zip' -DestinationPath 'D:\Allfiles'

Move-item -Path "D:\Allfiles\AZ-204-DevelopingSolutionsforMicrosoftAzure-master\Allfiles\*" -Destination "D:\Allfiles" -confirm:$false
```



