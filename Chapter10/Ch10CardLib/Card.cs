using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10CardLib
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        //因为牌的两个字段不能为空，所以要添加一个新的构造函数，让牌的对象创建时必然带有Rank和Suit字段
        //原本的默认构造函数放弃不用
        public Card(Suit newSuit,Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        private Card()
        {

        }
        //重写ToString函数
        public override string ToString()
        {
            return "The" + rank + "of" + suit +"s";
        }
    }
}