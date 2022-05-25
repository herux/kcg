﻿using Enums;
using UnityEngine;
using TileSpriteLoader;
using System.Collections;
using System;

namespace SpriteAtlas
{
    public class SpriteAtlasManager
    {
        private SpriteAtlas[] SpritesArray;
        private int[] Count;

        public SpriteAtlasManager()
        {
            SpritesArray = new SpriteAtlas[1];
            Count = new int[1];

            SpriteAtlas atlas = new SpriteAtlas();
            atlas.Width = 128;
            atlas.Height = 128;
            atlas.Data = new byte[4 * 32 * 32 * atlas.Width * atlas.Height]; // 4 * 32 * 32 = 4096

            SpritesArray[0] = atlas;
        }
        
        public ref SpriteAtlas GetSpriteAtlas(int id)
        {
            return ref SpritesArray[id];
        }

        public int GetGlTextureId(int id)
        {
            SpriteAtlas atlas = GetSpriteAtlas(id);
            return atlas.GLTextureID;
        }


        // will copy the tile from the SpriteAtlas with a given id
        // to the data byte array
        public void GetSpriteBytes(int id, byte[] data)
        {
            ref SpriteAtlas atlas = ref SpritesArray[0];

            int xOffset = (id % atlas.Width) * 32;
            int yOffset = (id / atlas.Height) * 32;

            for(int y = 0; y < 32; y++)
            {
                for(int x = 0; x < 32; x++)
                {
                    int index = 4 * (x + y * 32);
                    int atlasindex = 4 * ((yOffset + y) * (atlas.Width * 32) +
                                         (xOffset + x));
                    

                    data[index + 0] = atlas.Data[atlasindex + 0];
                    data[index + 1] = atlas.Data[atlasindex + 1];
                    data[index + 2] = atlas.Data[atlasindex + 2];
                    data[index + 3] = atlas.Data[atlasindex + 3];
                }
            }
        }

        // Returns sprite sheet id
        // Copies the 32x32 pixels from the SpriteSheet that
        // are located in the Column, Row
        // to the big SpriteAtlas we have and returns an id
        // the id will then be used to get the pixels back
        // from the SpriteAtlas 
        public int Blit(int SpriteSheetID, int Column, int Row)
        {
            SpriteSheet sheet = GameState.TileSpriteLoader.SpriteSheets[SpriteSheetID];
            ref SpriteAtlas atlas = ref SpritesArray[0];
            ref int count = ref Count[0];

            for (int y = 0; y < 32; y++)
                for (int x = 0; x < 32; x++)
                {
                    int xOffset = (count % atlas.Width) * 32;
                    int yOffset = (count / atlas.Height) * 32;
                    /*int atlasindex = 4 * ((yOffset + y) * atlas.Width + (x + xOffset));
                    int sheetindex = 4 * ((x + Row) + ( (y + Column) * sheet.Width));*/

                    int atlasindex = 4 * ((yOffset + y) * (atlas.Width * 32) + (xOffset + x));
                    int sheetindex = 4 * ((x + Column * 32) + ( (y + Row * 32) * sheet.Width));

                    atlas.Data[atlasindex + 0] = sheet.Data[sheetindex + 0];
                    atlas.Data[atlasindex + 1] = sheet.Data[sheetindex + 1];
                    atlas.Data[atlasindex + 2] = sheet.Data[sheetindex + 2];
                    atlas.Data[atlasindex + 3] = sheet.Data[sheetindex + 3];
                }

            // todo: upload texture to open gl

            count++;

            return count - 1;
        }


        // Returns sprite sheet id
        // Copies the 16x16 pixels from the SpriteSheet that
        // are located in the Column, Row
        // to the big SpriteAtlas as a 32x32 sprite, and returns an id
        // the id will then be used to get the pixels back
        // from the SpriteAtlas 
         public int Blit16(int SpriteSheetID, int Column, int Row)
        {
            SpriteSheet sheet = GameState.TileSpriteLoader.SpriteSheets[SpriteSheetID];
            ref SpriteAtlas atlas = ref SpritesArray[0];
            ref int count = ref Count[0];

            for (int y = 0; y < 16; y++)
                for (int x = 0; x < 16; x++)
                {
                    int xOffset = (count % atlas.Width) * 32;
                    int yOffset = (count / atlas.Height) * 32;
                    /*int atlasindex = 4 * ((yOffset + y) * atlas.Width + (x + xOffset));
                    int sheetindex = 4 * ((x + Row) + ( (y + Column) * sheet.Width));*/

                    //int atlasindex = 4 * 4 * ((yOffset + y) * (atlas.Width * 32) + (xOffset + x));
                    int sheetindex = 4 * ((x + Column * 16) + ( (y + Row * 16) * sheet.Width));

                    for(int j = 0; j < 2; j++)
                    {
                        for(int i = 0; i < 2; i++)
                        {
                            int atlasindex = 4 * ((yOffset + (y * 2) + j) * (atlas.Width * 32) + (xOffset + (x * 2) + i));

                            atlas.Data[atlasindex + 0] = sheet.Data[sheetindex + 0];
                            atlas.Data[atlasindex + 1] = sheet.Data[sheetindex + 1];
                            atlas.Data[atlasindex + 2] = sheet.Data[sheetindex + 2];
                            atlas.Data[atlasindex + 3] = sheet.Data[sheetindex + 3];
                        }
                    }

                }

            // todo: upload texture to open gl

            count++;

            return count - 1;
        }

        // Returns sprite sheet id
        // Copies the 8x8 pixels from the SpriteSheet that
        // are located in the Column, Row
        // to the big SpriteAtlas as a 32x32 sprite and returns an id
        // the id will then be used to get the pixels back
        // from the SpriteAtlas 
        public int Blit8(int SpriteSheetID, int Column, int Row)
        {
            SpriteSheet sheet = GameState.TileSpriteLoader.SpriteSheets[SpriteSheetID];
            ref SpriteAtlas atlas = ref SpritesArray[0];
            ref int count = ref Count[0];

            for (int y = 0; y < 8; y++)
                for (int x = 0; x < 8; x++)
                {
                    int xOffset = (count % atlas.Width) * 32;
                    int yOffset = (count / atlas.Height) * 32;
                    /*int atlasindex = 4 * ((yOffset + y) * atlas.Width + (x + xOffset));
                    int sheetindex = 4 * ((x + Row) + ( (y + Column) * sheet.Width));*/

                    //int atlasindex = 4 * 4 * ((yOffset + y) * (atlas.Width * 32) + (xOffset + x));
                    int sheetindex = 4 * ((x + Column * 8) + ( (y + Row * 8) * sheet.Width));

                    for(int j = 0; j < 4; j++)
                    {
                        for(int i = 0; i < 4; i++)
                        {
                            int atlasindex = 4 * ((yOffset + (y * 4) + j) * (atlas.Width * 32) + (xOffset + (x * 4) + i));
                    
                            atlas.Data[atlasindex + 0] = sheet.Data[sheetindex + 0];
                            atlas.Data[atlasindex + 1] = sheet.Data[sheetindex + 1];
                            atlas.Data[atlasindex + 2] = sheet.Data[sheetindex + 2];
                            atlas.Data[atlasindex + 3] = sheet.Data[sheetindex + 3];
                        }
                    }

                }

            // todo: upload texture to open gl

            count++;

            return count - 1;
        }
    }
}
