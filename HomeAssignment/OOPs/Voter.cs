using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Voter
    {
        long adharcardNo;
        string voterName;
        string votecastedto;
        public void setAdharCardNo(long adharcardNo)
        {
            this.adharcardNo = adharcardNo;
        }
        public long getAdharCardNo()
        {
            return adharcardNo;
        }
        public void setVoterName(string voterName)
        {
            this.voterName = voterName;
        }
        public string getVoterName()
        {
            return voterName;
        }
        public void setVoteCastedTo(string votecastedto)
        {
            this.votecastedto = votecastedto;
        }
        public string getVoteCastedTo()
        {
            return votecastedto;
        }

    }
    class Voter1
    {
        static void Main(string[] args)
        {
            Voter v = new Voter();
            v.setAdharCardNo(100023005566);
            v.setVoterName("Suraj");
            v.setVoteCastedTo("BJP");
            Console.WriteLine("Adhar No:"+ v.getAdharCardNo());
            Console.WriteLine("Voter Name:"+v.getVoterName());
            Console.WriteLine("Vote Casted to:"+ v.getVoteCastedTo());

        }
       
    }
}
