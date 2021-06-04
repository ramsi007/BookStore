using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility
{
    public static class SD
    {
        public const string Proc_CoverType_Create = "usp_CreateCoverType";
        public const string Proc_CoverType_Get = "usp_GetCoverType";
        public const string Proc_CoverType_GetAll = "usp_GetCoverTypes";
        public const string Proc_CoverType_Update = "usp_UpdateCoverType";
        public const string Proc_CoverType_Delete = "usp_DeleteCoverType";

        public const string Role_User_Indi = "Candidat Individuel";
        public const string Role_User_Comp = "Entreprise";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee";

        public const string ssShoppingCart = "Shoping Cart Session";

        public const string StatusPending = "En attente";
        public const string StatusApproved = "Approuvée";
        public const string StatusInProcess = "En cours";
        public const string StatusShipped = "Expédié";
        public const string StatusCancelled = "Annulé";
        public const string StatusRefunded = "Remboursé";

        public const string PaymentStatusPending = "En attente";
        public const string PaymentStatusApproved = "Approuvée";
        public const string PaymentStatusDelayedPayment = "Approuvé pour paiement retardé";
        public const string PaymentStatusRejected = "Rejetée";



        public static double GetPriceBasedOnQuantity(double quantity, double price, double price50, double price100)
        {
            if (quantity < 50)
            {
                return price;
            }
            else
            {
                if (quantity < 100)
                {
                    return price50;
                }
                else
                {
                    return price100;
                }
            }
        }

        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
    }
}
