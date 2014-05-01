﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Land.Enums;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Land.Classes
{
    public class GameSpritesCollection : ICollection<GameSprite>
    {
        private readonly List<GameSprite> _collection = new List<GameSprite>();
        private readonly ContentManager _content;

        public GameSpritesCollection(ContentManager content)
        {
            _content = content;
            LoadAllSprites();
        }

        private static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }


        private void LoadAllSprites()
        {
            _collection.Clear();
            LoadSprites(BackColorEnum.White);
            LoadSprites(BackColorEnum.Black);
        }

        private void LoadSprites(BackColorEnum backColor)
        {
            foreach (var itemType in GetValues<SpriteTypeEnum>())
            {
                var texturePath = string.Format(@"{0}\{1}", backColor, itemType);
                var texture = _content.Load<Texture2D>(texturePath);
                var item = new GameSprite(itemType, texture, backColor);
                _collection.Add(item);
            }
        }

        public void Add(GameSprite item)
        {
            _collection.Add(item);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public bool Contains(GameSprite item)
        {
            return _collection.Contains(item);
        }

        public void CopyTo(GameSprite[] array, int arrayIndex)
        {
            _collection.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _collection.Count; }
        }

        public GameSprite this[SpriteTypeEnum itemType, BackColorEnum backColor] 
        {
            get
            {
                return _collection.FirstOrDefault(c => c.ItemType == itemType && c.BackColor == backColor);
            }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool Remove(GameSprite item)
        {
            return _collection.Remove(item);
        }

        public IEnumerator<GameSprite> GetEnumerator()
        {
            return _collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}
