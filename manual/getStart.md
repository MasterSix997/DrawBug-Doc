# How to Get Started with DrawBug
This tutorial teaches you the basics of getting started with DrawBug.
- - -
## Drawing Shapes
Let's start by drawing a cube in the center of the scene.

Create a new C# script in Unity and write the following code:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code1)]

In your Unity scene, create a new object and add the script to it. When you hit `Play` you should see a cube in the
scene:

![Alt text](../resources/image1.png)

To position the cube in the object's position, orientation, and scale, write the following code:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code2)]

Now you should be able to manipulate the cube by changing the object's transform.

![Alt text](../resources/image2.png)

## Changing the style
You can customize the way DrawBug draws your objects.
Let's start by drawing a red cylinder:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code3)]

![Alt text](../resources/image3.png)

DrawBug accepts a DrawingStyle to draw its shapes, but what we did was pass a Color.red, because DrawBug implicitly converts it to a DrawingStyle.
The equivalent of our code above would be:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code4)]
Resulting in the same red cylinder.

### Available styles
The available styles are:

#### <span style="color:#6093e0">Color WireColor:</span> (color to be used when drawing lines)
Example:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code5)]

> This code won't draw anything; this is because when not using implicit converters, you need to specify which method to use for drawing, such as "wire" for example:

[!code-csharp[](GetStartCodes/BasicCube.cs#Code6)]

![Alt text](../resources/image4.png)

#### <span style="color:#6093e0">Color SolidColor:</span> (color to be used when drawing solid shapes)
[!code-csharp[](GetStartCodes/BasicCube.cs#Code7)]

![Alt text](../resources/image5.png)

#### <span style="color:#6093e0">DrawMethod DrawMethod:</span> (Specifies the way DrawBug will render its shapes)

##### <span style="color:#c9365e">• Wire</span>
[!code-csharp[](GetStartCodes/BasicCube.cs#Code8)]
![Alt text](../resources/image4.png)


##### <span style="color:#c9365e">• Solid</span>
[!code-csharp[](GetStartCodes/BasicCube.cs#Code9)]
![Alt text](../resources/image5.png)

##### <span style="color:#c9365e">• Both</span>
[!code-csharp[](GetStartCodes/BasicCube.cs#Code10)]
![Alt text](../resources/image6.png)

## Using DrawPhysics
Casts in Unity can be confusing to understand and debug. DrawBug can simplify this by adding bounding shapes to
check for collisions. Just replace Physics.(...) with DrawPhysics.(...).

#### Unity's default:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code11)]

#### Using DrawPhysics:
[!code-csharp[](GetStartCodes/BasicCube.cs#Code12)]