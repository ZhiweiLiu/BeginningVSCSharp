using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    public class Deck
    {
        private Cards cards = new Cards();

        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //这里不用确定索引号，通过Add方法直接依次加入集合中即可，类似python中的list的append方法
                    cards.Add(new Card((Suit)suitVal,(Rank)rankVal));
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum>=0 && cardNum<=51)
            {
                return cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be 0 to 51."));
            }
        }
        //洗牌
        public void Shuffle()
        {
            /*创建一副新牌组，对原来牌组中的元素进行遍历，每次遍历都会随机一个0 - 52的值
              以随机数为索引，将原牌组中的牌Add进新牌组；
              使用一个bool类型的数组，标记每个索引是否已经被复制过去
              如果已经复制过去了，再随到这个随机数就跳过；如果还没复制过去，就复制过去并把该索引标记为已复制
            */
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();

            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundcard = false;
                while (foundcard==false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard]==false)
                    {
                         foundcard= true;
                    }
                    assigned[sourceCard] = true;
                    newDeck.Add(cards[sourceCard]);
                }
            }
            newDeck.CopyTo(cards);
        }
    }
}