using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using MuffinDev.Core.EditorOnly;
#endif

using MuffinDev.Core;

namespace MuffinDev.BasicShapes
{

    /// <summary>
    /// References all basic shape prefabs, and add editor menus to instantiate them.
    /// </summary>
	[CreateAssetMenu(fileName = "Basic Shapes Index", menuName = "Muffin Dev/Basic Shapes/Basic Shapes Index")]
	public class BasicShapesIndex : ScriptableObjectSingleton<BasicShapesIndex>
	{

        #region Subclasses

        /// <summary>
        /// Represents a group of basic shapes prefabs.
        /// </summary>
        [System.Serializable]
        private class BasicShapesGroup
        {

            [SerializeField]
            private string m_GroupName = string.Empty;

            [SerializeField]
            private GameObject[] m_Prefabs = { };

            /// <summary>
            /// Gets the named prefab in th list.
            /// </summary>
            /// <param name="_PrefabName"></param>
            /// <returns></returns>
            public GameObject GetPrefab(string _PrefabName)
            {
                foreach(GameObject prefab in m_Prefabs)
                {
                    if(prefab.name == _PrefabName)
                    {
                        return prefab;
                    }
                }
                return null;
            }

            public string GroupName
            {
                get { return m_GroupName; }
            }

        }

        #endregion


        #region Properties

        [SerializeField]
        private BasicShapesGroup[] m_Shapes = { };

        #endregion


        #region Private Methods

        #if UNITY_EDITOR

        /// <summary>
        /// Instantiates a cone.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Advanced/Cone", false, 20)]
        private static void InstantiateCone()
        {
            InstantiateBasicShape("Advanced", "Cone");
        }

        /// <summary>
        /// Instantiates a cylinder.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Advanced/Cylinder", false, 20)]
        private static void InstantiateCylinder()
        {
            InstantiateBasicShape("Advanced", "Cylinder");
        }

        /// <summary>
        /// Instantiates a pyramid.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Advanced/Pyramid", false, 20)]
        private static void InstantiatePyramid()
        {
            InstantiateBasicShape("Advanced", "Pyramid");
        }

        /// <summary>
        /// Instantiates a torus.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Advanced/Torus", false, 20)]
        private static void InstantiateTorus()
        {
            InstantiateBasicShape("Advanced", "Torus");
        }

        /// <summary>
        /// Instantiates a tube.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Advanced/Tube", false, 20)]
        private static void InstantiateTube()
        {
            InstantiateBasicShape("Advanced", "Tube");
        }

        /// <summary>
        /// Instantiates a cube.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Basics/Cube", false, 20)]
        private static void InstantiateCube()
        {
            InstantiateBasicShape("Basics", "Cube");
        }

        /// <summary>
        /// Instantiates a sphere.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Basics/Sphere", false, 20)]
        private static void InstantiateSphere()
        {
            InstantiateBasicShape("Basics", "Sphere");
        }

        /// <summary>
        /// Instantiates a capsule, with its pivot at (0;0;0;) coordinates.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Capsules/Capsule (0;0;0)", false, 20)]
        private static void InstantiateCapsule000()
        {
            InstantiateBasicShape("Capsules", "Capsule000");
        }

        /// <summary>
        /// Instantiates a capsule, with its pivot at the bottom center.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Capsules/Capsule (Bottom pivot)", false, 20)]
        private static void InstantiateCapsuleBottomPivot()
        {
            InstantiateBasicShape("Capsules", "CapsuleBottomPivot");
        }

        /// <summary>
        /// Instantiates a plane, with a dimension of 1 by 1.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Planes/Plane 1x1", false, 20)]
        private static void InstantiatePlane1x1()
        {
            InstantiateBasicShape("Planes", "Plane1x1");
        }

        /// <summary>
        /// Instantiates a plane, with a dimension of 2 by 2.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Planes/Plane 2x2", false, 20)]
        private static void InstantiatePlane2x2()
        {
            InstantiateBasicShape("Planes", "Plane2x2");
        }

        /// <summary>
        /// Instantiates a plane, with a dimension of 5 by 5.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Planes/Plane 5x5", false, 20)]
        private static void InstantiatePlane5x5()
        {
            InstantiateBasicShape("Planes", "Plane5x5");
        }

        /// <summary>
        /// Instantiates a plane, with a dimension of 10 by 10.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Planes/Plane 10x10", false, 20)]
        private static void InstantiatePlane10x10()
        {
            InstantiateBasicShape("Planes", "Plane10x10");
        }

        /// <summary>
        /// Instantiates a plane, with a dimension of 20 by 20.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Planes/Plane 20x20", false, 20)]
        private static void InstantiatePlane20x20()
        {
            InstantiateBasicShape("Planes", "Plane20x20");
        }

        /// <summary>
        /// Instantiates a plane, with a dimension of 50 by 50.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Planes/Plane 50x50", false, 20)]
        private static void InstantiatePlane50x50()
        {
            InstantiateBasicShape("Planes", "Plane50x50");
        }

        /// <summary>
        /// Instantiates a quad (vertical plane), with a dimension of 1 by 1.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Quads/Quad 1x1", false, 20)]
        private static void InstantiateQuad1x1()
        {
            InstantiateBasicShape("Quads", "Quad1x1");
        }

        /// <summary>
        /// Instantiates a quad (vertical plane), with a dimension of 2 by 2.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Quads/Quad 2x2", false, 20)]
        private static void InstantiateQuad2x2()
        {
            InstantiateBasicShape("Quads", "Quad2x2");
        }

        /// <summary>
        /// Instantiates a quad (vertical plane), with a dimension of 5 by 5.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Quads/Quad 5x5", false, 20)]
        private static void InstantiateQuad5x5()
        {
            InstantiateBasicShape("Quads", "Quad5x5");
        }

        /// <summary>
        /// Instantiates a quad (vertical plane), with a dimension of 10 by 10.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Quads/Quad 10x10", false, 20)]
        private static void InstantiateQuad10x10()
        {
            InstantiateBasicShape("Quads", "Quad10x10");
        }

        /// <summary>
        /// Instantiates a quad (vertical plane), with a dimension of 20 by 20.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Quads/Quad 20x20", false, 20)]
        private static void InstantiateQuad20x20()
        {
            InstantiateBasicShape("Quads", "Quad20x20");
        }

        /// <summary>
        /// Instantiates a quad (vertical plane), with a dimension of 50 by 50.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 3D/Quads/Quad 50x50", false, 20)]
        private static void InstantiateQuad50x50()
        {
            InstantiateBasicShape("Quads", "Quad50x50");
        }

        /// <summary>
        /// Instantiates an arrow sprite.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 2D/Arrow", false, 20)]
        private static void Instantiate2DArrow()
        {
            InstantiateBasicShape("2D", "Arrow", true);
        }

        /// <summary>
        /// Instantiates a circle sprite.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 2D/Circle", false, 20)]
        private static void Instantiate2DCircle()
        {
            InstantiateBasicShape("2D", "Circle", true);
        }

        /// <summary>
        /// Instantiates a square sprite.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 2D/Square", false, 20)]
        private static void Instantiate2DSquare()
        {
            InstantiateBasicShape("2D", "Square", true);
        }

        /// <summary>
        /// Instantiates a triangle sprite.
        /// </summary>
        [MenuItem("GameObject/Basic Shapes 2D/Triangle", false, 20)]
        private static void Instantiate2DTriangle()
        {
            InstantiateBasicShape("2D", "Triangle", true);
        }

        /// <summary>
        /// Finds the named basic shape in the named group, and instantiates it.
        /// </summary>
        /// <param name="_Group">The name of the group (basically the prefabs folder).</param>
        /// <param name="_Name">The name of the prefab to instantiate.</param>
        private static void InstantiateBasicShape(string _Group, string _Name, bool _Is2D = false)
        {
            GameObject obj = Instance.GetPrefab(_Group, _Name);
            if(obj != null)
            {
                // If an object in the scene is selected, instantiate the prefab as a child of it
                if(Selection.activeTransform != null)
                {
                    Vector3 positionOffset = (!_Is2D) ? Vector3.one : new Vector3(1f, 1f, 0f);
                    obj = Instantiate(obj, Selection.activeTransform.position + positionOffset, Quaternion.identity, Selection.activeTransform);
                }
                else
                {
                    obj = Instantiate(obj, Vector3.zero, Quaternion.identity);
                }

                // Select the instantiated asset
                if(obj != null)
                {
                    obj.name = _Name;
                    EditorHelpers.FocusAsset(obj, true, false);
                }
            }
            else
            {
                Debug.LogWarning("Impossible to find the prefab " + _Name + " in " + _Group + " folder.");
            }
        }

        #endif

        #endregion


        #region Accessors

        /// <summary>
        /// Gets the named basic shape in the named group, and instantiates it.
        /// </summary>
        /// <param name="_Group">The name of the group (basically the prefabs folder).</param>
        /// <param name="_Name">The name of the prefab to instantiate.</param>
        private GameObject GetPrefab(string _Group, string _Name)
        {
            foreach(BasicShapesGroup group in m_Shapes)
            {
                if(group.GroupName == _Group)
                {
                    return group.GetPrefab(_Name);
                }
            }
            return null;
        }

        #endregion

    }

}