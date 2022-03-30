using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;
using Plugin;

namespace KompasWrapper
{
    public class CardanForkBuilder
    {

        /// <summary>
        /// Объект класса конектора для связи с КОММПАС-3D
        /// </summary>
        private KompasConnector _connector;

        /// <summary>
        /// Объект класса параметра для построение детали
        /// </summary>
        private CardanForkParameters _parameters;

        /// <summary>
        /// Стиль линии: основная
        /// </summary>
        private const int MainLineStyle = 1;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="parameters">Параметры карданной вилки</param>
        /// <param name="connector">Объект для связи с КОМПАС-3D</param>
        public CardanForkBuilder(CardanForkParameters parameters,
            KompasConnector connector)
        {
            _parameters = parameters;
            _connector = connector;
        }

        /// <summary>
        /// Метод строящий карданную вилку
        /// </summary>
        public void BuildCardanFork()
        {
            _connector.Start();
            _connector.CreateDocument3D();

            //Создание детали без отверстий и вырезов
            var sketch = CreateSketch(Obj3dType.o3d_planeXOZ, null);
            var doc2d = (ksDocument2D)sketch.BeginEdit();
            doc2d.ksRectangle(DrawRectangle(0, 0,
                _parameters.BaseWidth,
                _parameters.Height- _parameters.BaseWidth / 2));
            doc2d.ksCircle(_parameters.Height - _parameters.BaseWidth / 2,
                _parameters.BaseWidth / 2, _parameters.BaseWidth / 2,
                MainLineStyle);
            sketch.EndEdit();
            СreateExtrusion(sketch, _parameters.BaseLength);

            //Вырез деаметра на стенке детали
            sketch = CreateSketch(Obj3dType.o3d_planeXOZ,
                null);
            doc2d = (ksDocument2D)sketch.BeginEdit();
            doc2d.ksCircle(_parameters.Height - _parameters.BaseWidth / 2,
                _parameters.BaseWidth / 2, _parameters.WallHoleDiameter / 2,
                MainLineStyle);
            sketch.EndEdit();
            СreateCutExtrusion(sketch, _parameters.BaseLength, false);

            //Вырез пространства из середины
            sketch = CreateSketch(Obj3dType.o3d_planeXOY,
                null);
            doc2d = (ksDocument2D)sketch.BeginEdit();
            doc2d.ksRectangle(DrawRectangle(_parameters.BaseHeight,
                _parameters.WallThickness,
                _parameters.BaseLength - _parameters.WallThickness * 2,
                _parameters.Height - _parameters.BaseHeight));
            sketch.EndEdit();
            СreateCutExtrusion(sketch, _parameters.BaseLength);

            //Вырез отверстия в основании
            sketch = CreateSketch(Obj3dType.o3d_planeYOZ,
                null);
            doc2d = (ksDocument2D)sketch.BeginEdit();
            doc2d.ksCircle(_parameters.BaseLength/2,
                -_parameters.BaseWidth / 2, _parameters.BaseHoleDiameter/2,
                MainLineStyle);
            sketch.EndEdit();
            СreateCutExtrusion(sketch, _parameters.BaseHeight);
        }

        /// <summary>
        /// Метод рисования прямоугольника
        /// </summary>
        /// <param name="x">X базовой точки</param>
        /// <param name="y">Y базовой точки</param>
        /// <param name="height">Высота</param>
        /// <param name="width">Ширина</param>
        /// <returns>Переменная с параметрами прямоугольника</returns>
        private ksRectangleParam DrawRectangle(double x, double y,
            double height, double width)
        {
            var rectangleParam =
                (ksRectangleParam)_connector.Object.GetParamStruct
                    ((short)StructType2DEnum.ko_RectangleParam);
            rectangleParam.x = x;
            rectangleParam.y = y;
            rectangleParam.height = height;
            rectangleParam.width = width;
            rectangleParam.style = MainLineStyle;
            return rectangleParam;
        }

        /// <summary>
        /// Метод осущетсвляющий выдавливание
        /// </summary>
        /// <param name="sketch">Эскиз</param>
        /// <param name="depth">Расстояние выдавливания</param>
        private void СreateExtrusion(ksSketchDefinition sketch,
            double depth, bool side = true)
        {
            var extrusionEntity = (ksEntity)_connector.Part.NewEntity(
                (short)ksObj3dTypeEnum.o3d_bossExtrusion);
            var extrusionDef = (ksBossExtrusionDefinition)extrusionEntity
                .GetDefinition();

            extrusionDef.SetSideParam(side,
                (short)End_Type.etBlind, depth);
            extrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal :
                (short)Direction_Type.dtReverse;
            extrusionDef.SetSketch(sketch);

            extrusionEntity.Create();
        }

        /// <summary>
        /// Метод осуществляющий вырезание
        /// </summary>
        /// <param name="sketch">Эскиз</param>
        /// <param name="depth">Расстояние выреза</param>
        private void СreateCutExtrusion(ksSketchDefinition sketch,
            double depth, bool side = true)
        {
            var cutExtrusionEntity = (ksEntity)_connector.Part.NewEntity(
                (short)ksObj3dTypeEnum.o3d_cutExtrusion);
            var cutExtrusionDef =
                (ksCutExtrusionDefinition)cutExtrusionEntity
                    .GetDefinition();

            cutExtrusionDef.SetSideParam(side,
                (short)End_Type.etBlind, depth);
            cutExtrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal :
                (short)Direction_Type.dtReverse;
            cutExtrusionDef.cut = true;
            cutExtrusionDef.SetSketch(sketch);

            cutExtrusionEntity.Create();
        }

        /// <summary>
        /// Метод создающий эскиз
        /// </summary>
        /// <param name="planeType">Плоскость</param>
        /// <param name="offsetPlane">Объект смещения</param>
        /// <returns>Эскиз</returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType,
            ksEntity offsetPlane)
        {
            var plane = (ksEntity)_connector.Part
                .GetDefaultEntity((short)planeType);

            var sketch = (ksEntity)_connector.Part.
                NewEntity((short)Obj3dType.o3d_sketch);
            var ksSketch = (ksSketchDefinition)sketch.GetDefinition();

            if (offsetPlane != null)
            {
                ksSketch.SetPlane(offsetPlane);
                sketch.Create();
                return ksSketch;
            }

            ksSketch.SetPlane(plane);
            sketch.Create();
            return ksSketch;
        }

        /// <summary>
        /// Метод смещающий плоскость
        /// </summary>
        /// <param name="plane">Плоскость</param>
        /// <param name="offset">Расстояние смещения</param>
        /// <returns>Объект смещения</returns>
        private ksEntity CreateOffsetPlane(Obj3dType plane, double offset)
        {
            var offsetEntity = (ksEntity)_connector
                .Part.NewEntity((short)Obj3dType.o3d_planeOffset);
            var offsetDef = (ksPlaneOffsetDefinition)offsetEntity
                .GetDefinition();
            offsetDef.SetPlane((ksEntity)_connector
                .Part.NewEntity((short)plane));
            offsetDef.offset = offset;
            offsetDef.direction = false;
            offsetEntity.Create();
            return offsetEntity;
        }

        /// <summary>
        /// Создания фаски на выбранном ребре
        /// </summary>
        /// <param name="chamferRadius">Радиус</param>
        /// <param name="x">X-координата точки на ребре</param>
        /// <param name="y">Y-координата точки на ребре</param>
        /// <param name="z">Z-координата точки на ребре</param>
        private void CreateFillet(double chamferRadius, double x,
            double y, double z)
        {
            var filletEntity = (ksEntity)_connector
                .Part.NewEntity((short)Obj3dType.o3d_fillet);
            var filletDef =
                (ksFilletDefinition)filletEntity.GetDefinition();
            filletDef.radius = chamferRadius;
            filletDef.tangent = true;
            ksEntityCollection iArray = (ksEntityCollection)filletDef.array();
            ksEntityCollection iCollection = (ksEntityCollection)_connector
                .Part.EntityCollection((short)Obj3dType.o3d_edge);

            iCollection.SelectByPoint(x, y, z);
            var iEdge = iCollection.Last();
            iArray.Add(iEdge);
            filletEntity.Create();
        }
    }
}