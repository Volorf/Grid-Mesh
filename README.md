# Simple Grid Mesh
Create a mesh based grid for your cool Unity 3D project.

![Simple Grid Mesh](/gridMesh.gif)

## Three simple steps
1. [Import the Grid Mesh assset in your Unity 3D project](https://raw.githubusercontent.com/Volorf/Hover3D.js/master/hover3D.js);
2. Add `GridMesh` component to a GameObject;
3. Set it up.

<!-- 🔥 [YouTube Tutorial](https://youtube.com/) -->

## How to set up it via Inspector

## How to set up it via Code
You have a bunch of properties you can tweak to control the effect.
```csharp
private GridMesh _gridMesh;
private void Awake() 
{
    _gridMesh = GetComponent<GridMesh>();
}
private void Start()
{
    _gridMesh.xSegments = 16;
    _gridMesh.ySegments = 16;
    _gridMesh.color = Color.white;
    _gridMesh.xStep = 1.0f;
    _gridMesh.yStep = 1.0f;
}
```

## Links
[Portfolio](https://olegfrolov.design/) | [Linkedin](https://www.linkedin.com/in/oleg-frolov-6a6a4752/) | [Dribbble](https://dribbble.com/Volorf) | [Twitter](https://www.twitter.com/volorf) 

