﻿namespace CSharpGL
{
    /// <summary>
    ///
    /// </summary>
    public class PolygonModeState : GLState
    {
        private int[] originalPolygonMode = new int[2];

        /// <summary>
        ///
        /// </summary>
        public PolygonModeState() : this(PolygonMode.Fill) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="mode"></param>
        public PolygonModeState(PolygonMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Polygon Mode: {0}", Mode);
        }

        /// <summary>
        ///
        /// </summary>
        protected override void StateOn()
        {
            GL.Instance.GetIntegerv((uint)GetTarget.PolygonMode, originalPolygonMode);

            GL.Instance.PolygonMode((uint)GL.GL_FRONT_AND_BACK, (uint)this.Mode);
        }

        /// <summary>
        ///
        /// </summary>
        protected override void StateOff()
        {
            if (originalPolygonMode[0] == originalPolygonMode[1])
            {
                GL.Instance.PolygonMode(GL.GL_FRONT_AND_BACK, (uint)(originalPolygonMode[0]));
            }
            else
            {
                //TODO: not tested yet
                GL.Instance.PolygonMode(GL.GL_FRONT, (uint)originalPolygonMode[0]);
                GL.Instance.PolygonMode(GL.GL_BACK, (uint)originalPolygonMode[1]);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public PolygonMode Mode { get; set; }
    }
}