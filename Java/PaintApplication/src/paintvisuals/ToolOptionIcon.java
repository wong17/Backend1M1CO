/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package paintvisuals;

import painttools.StrokeStyle;
import paintapplication.Main;

import javax.swing.*;
import java.awt.Color;
import java.awt.Graphics;

public class ToolOptionIcon extends JPanel {

    protected StrokeStyle style;

    public ToolOptionIcon(StrokeStyle style) {
        this.style = style;
    }

    @Override
    public void paintComponent(Graphics g) {
        g.setColor(Main.paint.drawPanel.tool.getColor());

        if (null != style) {
            switch (style) {
                case DOT_CIRC:
                    g.fillOval(getWidth() / 7, getHeight() / 7, getWidth() / 7, getHeight() / 7 * 4);
                    g.fillOval(getWidth() / 7 * 3, getHeight() / 7, getWidth() / 7, getHeight() / 7 * 4);
                    g.fillOval(getWidth() / 7 * 5, getHeight() / 7, getWidth() / 7, getHeight() / 7 * 4);
                    break;
                case DOT_RECT:
                    g.fillRect(getWidth() / 7, getHeight() / 7, getWidth() / 7, getHeight() / 7 * 4);
                    g.fillRect(getWidth() / 7 * 3, getHeight() / 7, getWidth() / 7, getHeight() / 7 * 4);
                    g.fillRect(getWidth() / 7 * 5, getHeight() / 7, getWidth() / 7, getHeight() / 7 * 4);
                    break;
                case LINE:
                    g.fillRect(getWidth() / 9, getHeight() / 9 * 4, getWidth() / 9 * 7 + getWidth() / 9 * 2 / 3, getHeight() / 9 * 2);
                    break;
                case LINE_DASHED:
                    g.fillRect(getWidth() / 9 * 1, getHeight() / 9 * 4, getWidth() / 9 * 3 / 2, getHeight() / 9 * 2);
                    g.fillRect(getWidth() / 9 * 4, getHeight() / 9 * 4, getWidth() / 9 * 3 / 2, getHeight() / 9 * 2);
                    g.fillRect(getWidth() / 9 * 7, getHeight() / 9 * 4, getWidth() / 9 * 3 / 2, getHeight() / 9 * 2);
                    break;
                default:
                    break;
            }
        }

        if (null != style) {
            switch (style) {
                case OPEN_RECT:
                    g.drawRect(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3);
                    break;
                case OPEN_OVAL:
                    g.drawOval(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3);
                    break;
                case FILL_RECT:
                    g.fillRect(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3);
                    break;
                case FILL_OVAL:
                    g.fillOval(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3);
                    break;
                case FILL_ROUND_RECT:
                    g.fillRoundRect(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3, 10, 10);
                    break;
                case OPEN_ROUND_RECT:
                    g.drawRoundRect(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3, 10, 10);
                    break;
                default:
                    break;
            }
        }

        g.setColor(Color.black);

        if (style == StrokeStyle.SQUARE) {
            g.drawRect(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3);
        } else if (style == StrokeStyle.CIRCLE) {
            g.drawOval(getWidth() / 5, getHeight() / 5, getWidth() / 5 * 3, getHeight() / 5 * 3);
        }
    }
}
