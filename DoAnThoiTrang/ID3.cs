using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;
using DoAnThoiTrang.ClotheTableAdapters;

namespace DoAnThoiTrang
{
    class ID3
    {
        ClotheTableAdapter clo = new ClotheTableAdapter();
        public int ThuatToan(string weigh, string age, string height)
        {

            //đưa data vào thuạt toán
            DataTable data = clo.GetData();

            //float.Parse(DBNull.Value.ToString());
            // Tạo một sổ mã hóa mã hóa mới để 
            // chuyển đổi các chuỗi thành c ác ký hiệu số nguyên ví dụ A: 1, B: 2, C: 3,...
            Codification codebook = new Codification(data);

            //dịch thuật những dữ liệu train bằng những ký số đã được tạo ra ở cookbook
            DataTable symbols = codebook.Apply(data);

            int[][] inputs = symbols.ToArray<int>("weight", "age", "height");
            int[] outputs = symbols.ToArray<int>("size");

            //để tạo ra cây quyết định sử dụng thuật toán ID3 của quilan


            var id3learning = new ID3Learning()
            {
                //để đưa ra được dự đoán, sử dụng các yếu tố dự đoán 

                new DecisionVariable("weight",     96), // 
                new DecisionVariable("age",     82), // 5 possible values (A, B, C, D, F)    
                new DecisionVariable("height",    52),  // 5 possible values (A, B, C, D, F)    // 5 possible values (A, B, C, D, F)         
            };

            //đưa input , output vào để học
            DecisionTree tree = id3learning.Learn(inputs, outputs);

            // Compute the training error when predicting training instances
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

            // tạo ra một truy vấn để dự đoán
            int[] query = codebook.Transform(new[,]
            {
                {"weight",weigh },
                {"age", age },
                {"height", height }
            });

            // dự đoán kết quả bằng phương thức decide

            int predicted = tree.Decide(query);  // kết quả sẽ là 0 , 1 , đã được học
            if (predicted == -1)//kết quả -1 nghĩa là dữ liệu không đủ để train
                return -1;

            // thực hiện chuyển về dữ liệu chuỗi
            string answer = codebook.Revert("size", predicted); // Answer will be: "No"
            if (answer.Trim() == "XL")
                return 1;
            else if (answer.Trim() == "L")
                return 2;
            else if (answer.Trim() == "M")
                return 3;
            else if (answer.Trim() == "S")
                return 4;
            else if (answer.Trim() == "XXXL")
                return 5;
            else if (answer.Trim() == "XXL")
                return 6;
            else
                return 7;

        }
    }
}
