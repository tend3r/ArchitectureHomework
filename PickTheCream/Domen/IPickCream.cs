using System;
using System.Collections.Generic;
using System.Text;

namespace OilPastelChoise
{
    public interface IPickCream
    {
        public List<PickCream> ReadAll();
        public void AddPastel(PickCream pastel);
        public void DeleteOilPastel(int Id);
        public void UpdateOilPastel(int id, PickCream pastel);
        public List<PickCream> FindForBrand(string brand);
        public List<PickCream> FindFofUserLevel(string userLevel);
        public List<PickCream> FindForColorNumber(int colorNumber);
        public List<PickCream> FindForPrice(int minPrice, int maxPrice);

    }
}
