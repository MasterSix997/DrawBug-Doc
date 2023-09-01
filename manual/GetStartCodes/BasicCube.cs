#region Code1
using UnityEngine;
using DrawBug;

public class Tutorial : MonoBehaviour
{
    private void Update()
    {
        Drawbug.Cube(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(1, 1, 1));
    }
}
#endregion

#region Code2
using UnityEngine;
using DrawBug;

public class Tutorial : MonoBehaviour
{
    private void Update()
    {
        Drawbug.Cube(transform.position, transform.rotation, transform.localScale);
    }
}
#endregion

#region Code3
using UnityEngine;
using DrawBug;

public class Tutorial : MonoBehaviour
{
    private void Update()
    {
        Drawbug.Cylinder(transform.position, transform.rotation, 1, 2, 32, Color.red);
    }
}
#endregion

#region Code4
Drawbug.Cylinder(transform.position, transform.rotation, 1, 2, 32, new DrawingStyle(Color.red));
#endregion

#region Code5
var style = new DrawingStyle
{
    WireColor = new Color(0, 1, 0, 1)
};

Drawbug.Cube(transform.position, transform.rotation, transform.localScale, style);
#endregion

#region Code6
var style = new DrawingStyle
{
    WireColor = new Color(0, 1, 0, 1),
    DrawMethod = DrawMethod.Wire
};
#endregion

#region Code7
var style = new DrawingStyle
{
    SolidColor = new Color(0, 1, 0, 0.5f),
    DrawMethod = DrawMethod.Solid
};
#endregion

#region Code8
var style = new DrawingStyle
{
    WireColor = new Color(0, 1, 0, 1),
    DrawMethod = DrawMethod.Wire
};
#endregion

#region Code9
var style = new DrawingStyle
{
    SolidColor = new Color(0, 1, 0, 0.5f),
    DrawMethod = DrawMethod.Solid
};
#endregion

#region Code10
var style = new DrawingStyle
{
    WireColor = new Color(0, 1, 0, 1),
    SolidColor = new Color(0, 1, 0, 0.5f),
    DrawMethod = DrawMethod.Wire | DrawMethod.Solid
};
#endregion

#region Code11
private void FixedUpdate()
{
    Physics.Raycast(transform.position, Vector3.up, 5);
}
#endregion

#region Code12
private void FixedUpdate()
{
    DrawPhysics.Raycast(transform.position, Vector3.up, 5);
}
#endregion