using System;

        int[,,] matrix = new int[3, 3, 3];

       
        matrix[0,0,0] =5;
        matrix[0,0,1] =10;
        matrix[0,0,2] =15;
        matrix[0,1,0] =20;
        matrix[0,1,1] =25;
        matrix[0,1,2] =30;
        matrix[0,2,0] =35;
        matrix[0,2,1] =40;
        matrix[0,2,2] =45;

       
        matrix[1,0,0] =50;
        matrix[1,0,1] =55;
        matrix[1,0,2] =60;
        matrix[1,1,0] =65;
        matrix[1,1,1] =70;
        matrix[1,1,2] =75;
        matrix[1,2,0] =80;
        matrix[1,2,1] =85;
        matrix[1,2,2] =90;

        
        matrix[2,0,0] =95;
        matrix[2,0,1] =100;
        matrix[2,0,2] =105;
        matrix[2,1,0] =110;
        matrix[2,1,1] =115;
        matrix[2,1,2] =120;
        matrix[2,2,0] =125;
        matrix[2,2,1] =130;
        matrix[2, 2,2] =135;
        // Display the matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    Console.Write(matrix[i, j, k] + " ");
                }
                Console.WriteLine();
            }
        }
  
