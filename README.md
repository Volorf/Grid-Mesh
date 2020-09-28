# Grid Mesh — procedural mesh-based grid for Unity 3D
Create a procedural mesh-based grid for your cool project.

<img src="Images/demo2.gif" width="600">

## Three simple steps
1. [Get `GridMesh.cs`](https://raw.githubusercontent.com/Volorf/Grid-Mesh/master/GridMesh.cs);
2. Add `GridMesh` component to a game object;
3. Set it up.

## How to set it up via Inspector
<img src="Images/gridMeshUnityInspector.png" width="300">

* **`X Segments`** defines how many cells you will get on the X-axis.
* **`Y Segments`** defines how many cells you will get on the Y-axis.
* **`X Step`** defines cell's width.
* **`Y Step`** defines cell's height.
* **`Material`** allows you to set up material.
* **`isCentered`** Centers the grid to the centre of the game object

## How to set it up via Code
You have a bunch of properties you can tweak to control the grid.

```csharp
using UnityEngine;

public class GridMeshManager : MonoBehaviour
{
    public Material gridMat;
    private GridMesh _gridMesh;

    private void Awake() 
    {
        // Get GridMesh component
        _gridMesh = GetComponent<GridMesh>();
        // How many cell you will get on the X axis
        _gridMesh.xSegments = 8;
        // How many cell you will get on the Y axis
        _gridMesh.ySegments = 16;
        // Cell width
        _gridMesh.xStep = 1.0f;
        // Cell height
        _gridMesh.yStep = 0.5f;
        // Sets a material. By default it's magenta
        _gridMesh.material = gridMat;
        // Centers the grid to the game object
        _gridMesh.isCentered = true;
    }
}
```

## Good to know
* Developed with Unity 2019.4 7f1. Tested with higher versions, it worked well;
* Right now you can't change the thickness of the lines.

## Links
[Portfolio](https://olegfrolov.design/) | [Linkedin](https://www.linkedin.com/in/oleg-frolov-6a6a4752/) | [Dribbble](https://dribbble.com/Volorf) | [Twitter](https://www.twitter.com/volorf) 