using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Scriptable;

namespace Entities.Item
{
    public abstract class Item : MonoBehaviour
    {
        // All items have a GO
        [SerializeField]
        protected GameObject item;


        protected int id;
        protected ItemType type;
        protected new string name;
        protected string description;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            item = this.gameObject;
        }

        // Update is called once per frame
        protected abstract void Update();

        protected virtual int ID
        {
            get { return id; }
        }

        protected virtual ItemType Type
        {
            get { return type; }
        }

        protected virtual string Name
        {
            get { return name; }
        }

        protected virtual string Description
        {
            get { return description; }
        }
    }


}
