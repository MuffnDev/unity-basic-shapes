using System.Collections.Generic;
using UnityEngine;

namespace MuffinDev.BasicShapes.Utilities
{

	///<summary>
	/// Represents a Scriptable Object that can exist in the project only once, and can be get from anywhere.
	///</summary>
	public class ScriptableObjectSingleton<T> : ScriptableObject
        where T : ScriptableObjectSingleton<T>
    {

        #region Properties

        private static T s_Instance = null;

        #endregion


        #region Public Methods

        /// <summary>
        /// Checks if this singleton has an instance.
        /// </summary>
        public static bool HasInstance()
        {
            return FindAllInstances().Length > 0;
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Gets all the instances of objects in the project with the template type.
        /// </summary>
        private static T[] FindAllInstances()
        {
            T[] objs = null;

            #if UNITY_EDITOR
            // If we're running the game in the editor, the "Preloaded Assets" array will be ignored.
            // So get all the assets of this singleton's using AssetDatabase.
            List<T> objsList = new List<T>();
            string[] objsGUID = UnityEditor.AssetDatabase.FindAssets("t:" + typeof(T).Name);
            foreach(string guid in objsGUID)
            {
                objsList.Add(UnityEditor.AssetDatabase.LoadAssetAtPath<T>(UnityEditor.AssetDatabase.GUIDToAssetPath(guid)));
            }

            // Also get all assets from Resources or loaded assets.
            T[] objsFromResources = Resources.FindObjectsOfTypeAll<T>();
            foreach(T obj in objsFromResources)
            {
                if(!objsList.Contains(obj))
                {
                    objsList.Add(obj);
                }
            }

            objs = objsList.ToArray();
            #else
            // Get all asset of type T from Resources or loaded assets.
            objs = Resources.FindObjectsOfTypeAll<T>();
			#endif

            return objs;
        }

        #endregion


        #region Accessors
        
        /// <summary>
        /// Returns the only instance of this ScriptableObject.
        /// Note that if none or more than one asset of that type exist in the project, an error will be logged.
        /// </summary>
        public static T Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    T[] objs = FindAllInstances();

                    if(objs.Length == 1)
                    {
                        s_Instance = objs[0];
                    }
                    else if(objs.Length > 1)
                    {
                        Debug.LogError("There's more than one asset of type \"" + typeof(T).Name + "\" loaded in this project. We expect it to have a Singleton behaviour. Please remove other assets of that type from this project.");
                        s_Instance = objs[0];
                    }
                    else
                    {
                        Debug.LogError("No asset of type \"" + typeof(T).Name + "\" has been found in loaded resources. Please create a new one and add it to the \"Preloaded Assets\" array in Edit > Project Settings > Player > Other Settings.");
                        s_Instance = CreateInstance<T>();
                    }
                }

                return s_Instance;
            }
        }

        #endregion

	}

}