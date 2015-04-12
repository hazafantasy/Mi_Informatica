/**
 Author: Hazael Fernando Mojica García.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conjuntos
{
    class Set
    {
        private List<string> items;

        /*CONSTRUCTORS*/
        /*************************************************************************************************/

        public Set()
        {
            //Add Empty Item
            initEmpty();
        }

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="items">A string array which represent the items</param>
        public Set(List<string> items)
        {
            if (items != null)
                this.items = items;
            else
                initEmpty();
        }

        private void initEmpty()
        {
            this.items = new List<string>();
            this.items.Add(" ");
        }
        /*END CONSTRUCTORS*/
        /*************************************************************************************************/

        public List<string> getItems()
        {
            return this.items;
        }


        /// <summary>
        /// Applies the Intersection operation to this Set
        /// </summary>
        /// <param name="set_">The set to apply Intersection operation to this one</param>
        /// <returns>An instance os Set with the result of the Intersection operation</returns>
        public Set intersection(Set set_)
        {
            Set resultSet;
            List<string> setArray_ = set_.getItems();
            List<string> resultArray = new List<string>();

            for (int i = 0; i < setArray_.Count; i++)
            {
                if (this.items.Contains(setArray_[i]))
                    resultArray.Add(setArray_[i]);
            }
            resultSet = new Set(resultArray);
            return resultSet;
        }

        /// <summary>
        /// Applis the Union operation to this Set
        /// </summary>
        /// <param name="set_">The set to apply the Union operation to this one</param>
        /// <returns>An instance os Set with the result of the Union operation</returns>
        public Set union(Set set_)
        {
            Set resultSet;
            List<string> setArray_ = set_.getItems();
            List<string> resultArray = new List<string>(this.items);

            for (int i = 0; i < setArray_.Count; i++)
            {
                if(!resultArray.Contains(setArray_[i]))
                    resultArray.Add(setArray_[i]);
            }
            resultSet = new Set(resultArray);
            return resultSet;
        }

        /// <summary>
        /// Applis the difference operation to this Set (this.set - set_)
        /// </summary>
        /// <param name="set_">The set to apply the difference operation to this one</param>
        /// <returns>An instance os Set with the result of the difference operation</returns>
        public Set difference(Set set_)
        {
            Set resultSet;
            List<string> setArray_ = set_.getItems();
            List<string> resultArray = new List<string>(this.items);

            for (int i = 0; i < setArray_.Count; i++)
            {
                if (resultArray.Contains(setArray_[i]))
                    resultArray.Remove(setArray_[i]);
            }

            //Insert empty item (it has been eliminated)
            resultArray.Insert(0, " ");
            resultSet = new Set(resultArray);
            return resultSet;
        }

        /// <summary>
        /// Apply the cartesian operation to this Set
        /// </summary>
        /// <param name="set_">The set to apply the Union operation to this one</param>
        /// <returns>An instance os Set with the result of the cartesian Product operation</returns>
        public Set cartesianProduct(Set set_)
        {
            Set resultSet;
            List<string> setArray = new List<string>(this.items);
            List<string> setArray_ = set_.getItems();
            List<string> resultArray = new List<string>();

            //Remove both empty items
            setArray.RemoveAt(0);
            setArray_.RemoveAt(0);

            for (int i = 0; i < setArray.Count; i++)
            {
                for (int j = 0; j < setArray_.Count; j++)
                    resultArray.Add("(" + setArray[i] + ", " + setArray_[j] + ")");
            }

            //Add empty item
            resultArray.Insert(0, " ");
            resultSet = new Set(resultArray);
            return resultSet;
        }

        public override string ToString()
        {
            string itemsS = "";
            itemsS += "{";
            for (int i = 0; i < this.items.Count; i++)
                itemsS += this.items[i].ToString() + ",";
            //Delete last comma
            itemsS = itemsS.Substring(0, itemsS.Length - 1);
            itemsS += "}";

            return itemsS;
        }
    }
}
