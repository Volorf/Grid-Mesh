# Simple Grid Mesh
Create a mesh based grid for your cool Unity 3D project.

![Simple Grid Mesh](/gridMesh.gif)

## Three simple steps
1. [Download it](https://raw.githubusercontent.com/Volorf/Hover3D.js/master/hover3D.js);
2. Import `hover3D.js` to your Unity 3D project;
3. Add `Grid Mesh` to a gameobject.

🔥 [YouTube Tutorial](https://olegfrolov.design/hover3D/)

## How to set up it via Inspector

## How to set up it via Code
You have a bunch of properties you can tweak to control the effect.
```csharp
[SerializedField] private GridMesh _gridMesh;
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

