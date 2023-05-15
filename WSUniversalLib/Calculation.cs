using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// расчет количество необходимого сырья с учетом возможного 
        
 /// </summary>
/// <param name="productType">Тип продукта </param>
/// <param name="materialType">Тип материала </param>
/// <param name="count">ко-во продкутов </param>
/// <param name="width">ширина</param>
/// <param name="length">длинна </param>
/// <returns> единиц необходимого сырья (-1) если не верные 

 public int GetQuantityForProduct(int productType, int
 materialType,
 int count, float width, float length)
        {
            if (count <= 0 || width <= 0 || length <= 0)
                return -1;
            try
            {
                float coefProductType = GetProductType(productType);
                float coefMaterialType = GetMaterialType(materialType);
                float notDefect = GetMaterialNotDefect(coefProductType,
                count, width, length);
                float defect = GetDefect(notDefect, coefMaterialType);
                return RoundUp(notDefect + defect);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        private int RoundUp(float itog)
        {
            return (int)Math.Ceiling(itog);
        }
        private float GetDefect(float notDefect, float coefMaterialType)
        {
            return (float)Math.Ceiling(notDefect * coefMaterialType);
        }
        private float GetMaterialNotDefect(float coefProductType, int
count, float width, float length)
        {
            return coefProductType * width * length * count;
        }
        private float GetMaterialType(int materialType)
        {
            switch (materialType)
            {
                case 1: return 0.003f;
                case 2: return 0.0012f;
                default: throw new Exception();
            }
        }
        private float GetProductType(int productType)
        {
            switch (productType)
            {
                case 1: return 1.1f;
                case 2: return 2.5f;
                case 3: return 8.43f;
                default: throw new Exception();
            }
        }
    }


}
