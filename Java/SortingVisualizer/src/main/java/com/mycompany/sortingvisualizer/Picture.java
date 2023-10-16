/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.sortingvisualizer;

import java.awt.image.BufferedImage;
import java.io.IOException;
import javax.imageio.ImageIO;

/**
 *
 * @author Wong
 */
public class Picture {

    private int[] pixels;
    private BufferedImage image;
    private String path;

    public Picture(String path) {
        this.path = path;
        load();
    }

    private void load() {
        try {
            image = ImageIO.read(Picture.class.getResource(path));
            int w = image.getWidth();
            int h = image.getHeight();
            pixels = new int[w * h];
            image.getRGB(0, 0, w, h, pixels, 0, w);
        } catch (IOException e) {
            System.out.println(e);
        }
    }

    public int[] getPixels() {
        return pixels;
    }

    public int getWidth() {
        return image.getWidth();
    }

    public int getHeight() {
        return image.getHeight();
    }

}
