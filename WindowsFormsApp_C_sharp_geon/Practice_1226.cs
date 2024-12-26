using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp_C_sharp_geon
{
    public class User
    {
        public int Cash { get; private set; }
        public int CreditLimit { get; private set; }
        public int UsedCredit { get; private set; }

        public User(int cash, int creditlimit, int usedcredit)
        {
            Cash = cash;
            CreditLimit = creditlimit;
            UsedCredit = usedcredit;
            
        }

        public bool PaywithCash(int amount)
        {
            if (Cash >= amount)
            {
                Cash -= amount;
                return true;
            }
            return false;
        }

        public bool PaywithCard(int amount)
        {
            if (UsedCredit + amount <= CreditLimit)
            {
                UsedCredit += amount;
                return true;
            }
            return false;
        }
    }
    public class VendingMachine
    {
        private Dictionary<string, int> Menu { get; set; }

        public VendingMachine(Dictionary<string, int> menu)
        {
            Menu = menu;
        }

        // 메뉴 출력
        public void ShowMenu()
        {
            Console.WriteLine("===== 메뉴 =====");
            foreach (var item in Menu)
            {
                Console.WriteLine($"{item.Key}: {item.Value}원");
            }
        }

        // 메뉴 추가
        public void AddMenuItem(string itemName, int price)
        {
            if (Menu.ContainsKey(itemName))
            {
                Console.WriteLine($"'{itemName}'은(는) 이미 메뉴에 있습니다.");
            }
            else
            {
                Menu[itemName] = price;
                Console.WriteLine($"'{itemName}'이(가) {price}원으로 추가되었습니다.");
            }
        }

        // 메뉴 삭제
        public void RemoveMenuItem(string itemName)
        {
            if (Menu.ContainsKey(itemName))
            {
                Menu.Remove(itemName);
                Console.WriteLine($"'{itemName}'이(가) 메뉴에서 삭제되었습니다.");
            }
            else
            {
                Console.WriteLine($"'{itemName}'은(는) 메뉴에 없습니다.");
            }
        }

        // 메뉴 가격 수정
        public void UpdateMenuItemPrice(string itemName, int newPrice)
        {
            if (Menu.ContainsKey(itemName))
            {
                Menu[itemName] = newPrice;
                Console.WriteLine($"'{itemName}'의 가격이 {newPrice}원으로 변경되었습니다.");
            }
            else
            {
                Console.WriteLine($"'{itemName}'은(는) 메뉴에 없습니다.");
            }
        }

        // 구매 처리
        public string Purchase(User user, string menuName, bool useCard)
        {
            if (!Menu.ContainsKey(menuName))
            {
                return "선택한 메뉴가 없습니다.";
            }

            int price = Menu[menuName];
            bool paymentSuccess = useCard
                ? user.PaywithCard(price)
                : user.PaywithCash(price);

            if (paymentSuccess)
            {
                return $"'{menuName}'을(를) 구매하셨습니다. 음료를 투하합니다.";
            }
            else
            {
                return "결제 실패: 잔액이 부족합니다.";
            }
        }
    }

}