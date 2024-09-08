namespace Pepris {
    internal class ShapesHandler {
        private static Shape[] shapesArray;

        static ShapesHandler() {
            shapesArray = [
                // O block
                new Shape {
                    Width = 2,
                    Height = 2,
                    Dots = new int[,]
                    {
                        { 1, 1 },
                        { 1, 1 }
                    },
                },
                // I block
                new Shape { 
                    Width = 1,
                    Height = 4,
                    Dots = new int[,]
                    {
                        { 1 },
                        { 1 },
                        { 1 },
                        { 1 }
                    }
                },
                // T block
                new Shape {
                    Width = 3,
                    Height = 2,
                    Dots = new int[,]
                    {
                        { 0, 1, 0 },
                        { 1, 1, 1 }
                    }
                },
                // L block
                new Shape {
                    Width = 3,
                    Height = 2,
                    Dots = new int[,]
                    {
                        { 0, 0, 1 },
                        { 1, 1, 1 }
                    }
                },
                // J block
                new Shape {
                    Width = 3,
                    Height = 2,
                    Dots = new int[,]
                    {
                        { 1, 0, 0 },
                        { 1, 1, 1 }
                    }
                },
                // Z block
                new Shape {
                    Width = 3,
                    Height = 2,
                    Dots = new int[,]
                    {
                        { 1, 1, 0 },
                        { 0, 1, 1 }
                    }
                },
                // S block
                new Shape {
                    Width = 3,
                    Height = 2,
                    Dots = new int[,]
                    {
                        { 0, 1, 1 },
                        { 1, 1, 0 }
                    }
                }
            ];
        }
        public static Shape GetRandomShape() {
            var shape = shapesArray[new Random().Next(shapesArray.Length)];

            return shape;
        }
    }
}
