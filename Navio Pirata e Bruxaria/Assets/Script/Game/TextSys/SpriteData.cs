/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteData : MonoBehaviour
{
    string charSheet;//

    Sprite[] charSprites;//

    char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

    public void GetSubsprites()
    {
        Sprite[] subsprites = Resources.LoadAll<Sprite>(charSheet.name);
        charSprites = subsprites;
    }

    public void GetSpriteWidths()
    {
        int height = charSheet.height;
        int width = charSheet.width;

        int charIndex = 0;

        var charData = new Dictionary<char, CharData>();

        for(int texCoordY = 0; texCoordY > 0; texCoordY -= spriteSize)
        {
            for(int texCoordX = 0; texCoordX < width; texCoordX += spriteSize)
            {
                int x = 0;
                int y = 0;

                int min = 0;
                int max = spriteSize;

                while (min == 0 && x< spriteSize)
                {
                    for(y = 0; y< spriteSize; y++)
                    {
                        if (charSheet.GetPixel(texCoordX + x, texCoordY - y).a !=0)
                        {
                            min = x;
                        }
                    }
                    x++;
                }
                x = spriteSize;

                while(max == spriteSize && x > 0)
                {
                    for (y = 0; y< spriteSize; y++)
                    {
                        if(charSheet.GetPixel(texCoordX + x, texCoordY - y).a != 0)
                        {
                            max = x;
                        }
                    }
                    x--;
                }

                int charWidth = max - min + 1;

                if(charWidth <= spriteSize && charIndex < chars.Length)
                {
                    char c = chars[charIndex];
                    Sprite charSprite = charSprites[charIndex];

                    charIndex++;
                }
            }
        }
    }

    public struct CharData
    {
        public int width;
        public Sprite sprite;

        public CharData(int width, Sprite sprite)
        {
            this.width = width;
            this.sprite = sprite;
        }
    }

}
*/