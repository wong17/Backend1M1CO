/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.dev.app;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.Rectangle2D;
import java.util.Random;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;
import javax.swing.SwingWorker;

/**
 *
 * @author Wong
 */
public class InsertionSort extends JPanel {

    private static final int WIDTH_SCREEN = 1000;
    private static final int HEIGHT_SCREEN = WIDTH_SCREEN * 9 / 16;

    private Graphics2D g2d;
    // The bars to be drawn
    private Rectangle2D.Float bar;
    // Number of bars
    private final int SIZE = 200;
    // Bars width
    private final float BAR_WIDTH = (float) WIDTH_SCREEN / SIZE;
    // Bars height
    private final float barsHeight[] = new float[SIZE];
    private SwingWorker<Void, Void> shuffler, sorter;
    private int currentIndex, traversingIndex;

    public InsertionSort() {
        setBackground(Color.BLACK);
        setPreferredSize(new Dimension(WIDTH_SCREEN, HEIGHT_SCREEN));
        initBarHeight();
        initSorter();
        initShuffler();
    }

    private void initBarHeight() {
        float interval = (float) HEIGHT_SCREEN / SIZE;
        for (int i = 0; i < SIZE; i++) {
            barsHeight[i] = i * interval;
        }
    }

    private void initShuffler() {
        shuffler = new SwingWorker<Void, Void>() {
            @Override
            protected Void doInBackground() throws InterruptedException {
                int middle = SIZE / 2;
                for (int i = 0, j = middle; i < middle; i++, j++) {
                    int randomIndex = new Random().nextInt(SIZE);
                    swap(i, randomIndex);

                    randomIndex = new Random().nextInt(SIZE);
                    swap(j, randomIndex);

                    Thread.sleep(10);
                    repaint();
                }
                return null;
            }

            @Override
            protected void done() {
                super.done();
                sorter.execute();
            }
        };
        shuffler.execute();
    }

    private void initSorter() {
        sorter = new SwingWorker<Void, Void>() {
            @Override
            protected Void doInBackground() throws InterruptedException {
                for (currentIndex = 1; currentIndex < SIZE; currentIndex++) {
                    traversingIndex = currentIndex;
                    while (traversingIndex > 0
                            && (barsHeight[traversingIndex] < barsHeight[traversingIndex - 1])) {
                        swap(traversingIndex, traversingIndex - 1);
                        traversingIndex--;

                        Thread.sleep(1);
                        repaint();
                    }
                }
                currentIndex = 0;
                traversingIndex = 0;
                return null;
            }
        };
    }

    private void swap(int arrayIndex, int randomIndex) {
        float tempValue = barsHeight[arrayIndex];
        barsHeight[arrayIndex] = barsHeight[randomIndex];
        barsHeight[randomIndex] = tempValue;
    }

    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        g2d = (Graphics2D) g;
        g2d.setColor(Color.CYAN);
        for (int i = 0; i < SIZE; i++) {
            bar = new Rectangle2D.Float(i * BAR_WIDTH, 0, BAR_WIDTH, barsHeight[i]);
            g2d.fill(bar);
        }
        
        g2d.setColor(Color.RED);
        bar = new Rectangle2D.Float(currentIndex * BAR_WIDTH, 0, BAR_WIDTH, barsHeight[currentIndex]);
        g2d.fill(bar);
        
        g2d.setColor(Color.GREEN);
        bar = new Rectangle2D.Float(traversingIndex * BAR_WIDTH, 0, BAR_WIDTH, barsHeight[traversingIndex]);
        g2d.fill(bar);
        
        g2d.setColor(Color.WHITE);
        g2d.setFont(new Font("Consolas", Font.PLAIN, 20));
        g2d.drawString("INSERTION SORT - VISUALIZER", 10, HEIGHT_SCREEN - 10);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Insertion Sort Visualizer");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setResizable(false);
            frame.setContentPane(new InsertionSort());
            frame.validate();
            frame.pack();
            frame.setLocationRelativeTo(null);
            frame.setVisible(true);
        });
    }
}
