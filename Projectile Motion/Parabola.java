import java.awt.*;
import java.awt.event.*;
import java.math.*;
public class Parabola extends Frame implements TextListener{
    Canvas c1; Thread t1;
    Label l1,l2,l3; TextField tf1,tf2; Button b1,b2;
    float v,th;boolean flag;
    public Parabola(){
    	super();

    	setTitle("Physical Simulation");
        setSize(700,440);
        setLayout(null);

        c1=new Canvas();
        c1.setBounds(0,80,480,360);
        c1.setBackground(Color.green);
        this.add(c1);

        l1=new Label("Projectile Motion");
        l1.setBounds(180,35,120,50);
        this.add(l1);

        l2=new Label("velocity[m/s]");
        l2.setBounds(490,305,64,20);
        this.add(l2);

        l3=new Label("angle[��]");//0x81><
        l3.setBounds(490,330,88,20);
        this.add(l3);

        tf1=new TextField();
        tf1.setBounds(590,305,80,20);
        tf1.addTextListener(this);
        this.add(tf1);

        tf2=new TextField();
        tf2.setBounds(590,330,80,20);
        tf2.addTextListener(this);
        this.add(tf2); 

        b1=new Button("start");
        b1.setBounds(520,370,70,25);
        b1.addActionListener(new Graph());
        this.add(b1);

        b2=new Button("end");
        b2.setBounds(520,400,70,25);
        b2.addActionListener(new Graph());
        this.add(b2);
       
        this.setVisible(true);
    }public static void main(String[] args){
    	new Parabola();
    }public void textValueChanged(TextEvent e){
    	try{
            flag=false;
    		if((TextField)e.getSource()==tf1){
    			v=Float.parseFloat(tf1.getText());
            }else{
                th=Float.parseFloat(tf2.getText());
            }
        }catch(NumberFormatException ex){
            flag=true;
        }
    }class Graph implements ActionListener,Runnable{
        int x1,y1,x2,y2; final double gr=4.9;
        double vx,vy;
        double t; final double dt=0.1;
        public void actionPerformed(ActionEvent e){
            if(flag){
                tf1.setText("input number");
                tf2.setText("input number");
            }else if(e.getSource()==b1){
                vx=v*Math.cos(Math.toRadians(th));
                vy=v*Math.sin(Math.toRadians(th));
                x1=30; y1=330; x2=0; y2=0; t=0;

                t1=new Thread(this);
                t1.start();
            }else{
                System.exit(0);
            }
        }public void run(){
            try{
                Graphics g=c1.getGraphics();
                while(y2<330){
                    t+=dt;
                    x2=(int)(vx*t)+30; y2=(int)(gr*t*t-vy*t)+330;

                    g.setColor(Color.black);
                    g.drawLine(x1,y1,x2,y2);
                    g.setColor(Color.red);
                    g.drawLine(30,0,30,360);
                    g.drawLine(0,330,480,330);

                    x1=x2; y1=y2;
                    t1.sleep(30);
                }g.dispose();
            }catch(InterruptedException e){
                System.out.println(e);
            }
        }
    }
}