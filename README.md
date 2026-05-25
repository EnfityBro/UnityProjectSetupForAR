# Полностью готовый шаблон проекта для начала разработки AR игр на Unity

Инструкция по добавлению AR и базовой настройке игрока:
1. Создать проект, выбрать Universal 3D (URP) 
2. Импортировать AR Foundation 
3. Импортировать Google ARCore XR Plugin 
4. Импортировать OpenXR Plugin 
5. Импортировать XR Interaction Toolkit</br> 
  5.1. В окне Samples импортировать Starter Assets</br> 
  5.2. В окне Samples импортировать AR Starter Assets 
6. File -> Build Profiles (Build Settings) -> Android -> Switch Platform 
7. Edit -> Project Settings -> XR Plug-in Management</br> 
  7.1. -> вкладка андроид -> Google ARCore</br> 
  7.2. -> вкладка ПК -> XR Simulation</br> 
  7.3. -> Project Validation -> проверить нет ли ошибок / предупреждений, если есть, нажать fix all 
8. Edit -> Project Settings -> Player -> вкладка андроид -> Other Settings</br> 
  8.1. -> Graphics APIs -> удалить Vulkan</br> 
  8.2. -> Minimum API Level -> Android 7.0 'Nougat' (API level 24)</br> 
  8.3. -> Active Input Handing -> Input System Package (New) - рекомендуется, но можно оставить и Both 
9. Edit -> Project Settings -> Graphics -> Default Render Pipeline -> Mobile (по умолчанию называется Mobile_RPAsset) 
10. Edit -> Project Settings -> Quality -> Levels -> Mobile 
11. Папка Assets -> Settings -> Mobile_Renderer -> Add Renderer Feature -> AR Background Renderer Feature 
12. В иерархии -> ПКМ -> XR</br> 
  12.1. -> AR Session</br> 
  12.2. -> XR Origin (Mobile AR) 
13. В иерархии выбрать XR Origin (Mobile AR)</br> 
  13.1. -> AR Plane Manager -> Plane Prefab -> AR Feathered Plane (если не выбирается, то этот префаб можно найти по пути Assets -> Samples -> XR Interaction Toolkit -> [номер версии] -> AR Starter Assets -> Prefabs -> AR Feathered Plane)</br> 
  13.2. -> Detection Mode -> Horizontal (теперь трекаться будут только горизонтальные объекты)</br> 
  13.3. -> Add component -> AR Anchor Manager 
